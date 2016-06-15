using UnityEngine;
using System.Collections;

public class UpElevator : MonoBehaviour
{

    public bool subindo;
    public bool descendo;
    public bool parado;
    public bool um;
    public bool dois;
    public bool tres;

    public bool check;

    public Transform terreo;
    public Transform primeiroAndar;
    public Transform segundoAndar;
    public Transform terceiroAndar;

    public float speed;
    float aux;
          

    public GameObject botao;

    Collision colisao;


    // com FixedUpdate não fica travando
    void FixedUpdate()
    {

        /***** DESCE ****/
        // elevador desce para o terreo
        if (descendo == true && um == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, terreo.transform.position, speed * Time.deltaTime);
        }


        // elevador desce para o 1º andar
        if (descendo == true && dois == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, primeiroAndar.transform.position, speed * Time.deltaTime);
        }

        /***** SOBE ****/
        // elevador sobe para o 1º andar
        if (subindo == true && um == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, primeiroAndar.transform.position, speed * Time.deltaTime);
        }

        // elevador sobe para o 2º andar
        if (subindo == true && dois == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, segundoAndar.transform.position, speed * Time.deltaTime);
        }


        /***** CONTROLA BOTÃO *****/
        // se o elevador estiver parado o botão fica vermelho
        if (transform.position == terreo.transform.position || transform.position == primeiroAndar.transform.position || transform.position == segundoAndar.transform.position || transform.position == terceiroAndar.transform.position)
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
        if (parado == true)
        {
            // se a tecla 'u' for apertada o elevador SOBE
            if (Input.GetKeyDown("u"))
            {
                subindo = true;
                descendo = false;
                // 1° andar
                if (transform.position == terreo.transform.position)
                {
                    um = true;
                }

                // 2° andar
                if (transform.position == primeiroAndar.transform.position)
                {                    
                    um = false;
                    dois = true;
                }
            }

            // se a tecla 'j' for apertada o elevador DESCE
            if (Input.GetKeyDown("j"))
            {
                subindo = false;
                descendo = true;
                
                // terreo
                if (transform.position == primeiroAndar.transform.position)
                {
                    um = false;
                }

                //1° andar
                if (transform.position == segundoAndar.transform.position)
                {
                    dois = false;
                }

            }//fim da tecla

        }//fim parado
    }
}


