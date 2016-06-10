using UnityEngine;
using System.Collections;

public class UpElevator : MonoBehaviour
{

    public bool subindo;
    public bool descendo;
    public bool parado;
    public bool dois;
    public bool tres;

    public bool check;

    public Transform primeiroAndar;
    public Transform segundoAndar;
    public Transform terceiroAndar;

    public float speed;
          

    public GameObject botao;

    Collision colisao;


    // com FixedUpdate não fica travando
    void FixedUpdate()
    {

        /***** DESCE ****/
        // elevador desce para o 1º andar
        if (descendo == true && dois == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, primeiroAndar.transform.position, speed * Time.deltaTime);

        }


        // elevador desce para o 2º andar
        if (descendo == true && tres == false)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, segundoAndar.transform.position.y, transform.position.z), speed * Time.deltaTime);
        }


        /***** SOBE ****/
        // elevador sobe para o 2º andar
        if (subindo == true)
        {
            //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 3, transform.position.z), speed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, segundoAndar.transform.position, speed * Time.deltaTime);
        }

        // elevador sobe para o 3º andar
        if (subindo == true && dois == true)
        {
            //sobe muito devagar, quando começa a chegar perto do destino
            //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, terceiroAndar.transform.position.y, transform.position.z), speed * Time.deltaTime);

            // sobe muito rápido por causa do 50f 
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, terceiroAndar.transform.position.y, transform.position.z), speed * 50f * Time.deltaTime);

            //transform.position = Vector3.MoveTowards(transform.position, terceiroAndar.transform.position, speed * Time.deltaTime); 
        }



        /***** CONTROLA BOTÃO *****/ 
        // se o elevador estiver parado o botão fica vermelho
        if (transform.position == primeiroAndar.transform.position || transform.position == segundoAndar.transform.position || transform.position == terceiroAndar.transform.position)
        {
            botao.GetComponent<Renderer>().materials[0].color = Color.red;
            parado = true;
            subindo = false;
            descendo = false;

        }
        else
        // se o elevador estiver subindo/descendo o botão fica verde
        {
            botao.GetComponent<Renderer>().materials[0].color = Color.green;
            parado = false;
        }


        /***** TECLAS CLICADAS *****/
        // se a tecla 'u' for apertada e o elevador estiver parado sobe
        if (Input.GetKeyDown("u") && parado == true)
        {
            //primeiro andar
            if (transform.position == primeiroAndar.transform.position)
            {
                subindo = true;
                descendo = false;
            }

            //segundo andar
            if (transform.position == segundoAndar.transform.position)
            {
                subindo = true;
                descendo = false;
                dois = true;
            }
        }

        // se a tecla 'j' for apertada e o elevador estiver parado desce
        if (Input.GetKeyDown("j") && parado == true)
        {
            //desce para o 1° andar
            if (transform.position == segundoAndar.transform.position)
            {
                subindo = false;
                descendo = true;
                dois = false;
            }

            //desce para o 2° andar
            if (transform.position == terceiroAndar.transform.position)
            {
                subindo = false;
                descendo = true;
                tres = false;
            }
        }
    }

  
}

