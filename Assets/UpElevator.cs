using UnityEngine;
using System.Collections;

public class UpElevator : MonoBehaviour
{

    public bool subindo;
    public bool descendo;
    public bool parado;


    public Transform primeiroAndar;
    public Transform segundoAndar;


    public float speed;

    public GameObject botao;


    // com FixedUpdate não fica travando
    void FixedUpdate()
    {

        // elevador sobe para o 2º andar
        if (subindo == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, segundoAndar.transform.position, speed * Time.deltaTime);
        }

        // elevador desce para o 1º andar
        if (descendo == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, primeiroAndar.transform.position, speed * Time.deltaTime);
        }

        // se o elevador estiver parado o botão fica vermelho
        if (transform.position == primeiroAndar.transform.position || transform.position == segundoAndar.transform.position)
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

        // se a tecla 'u' for apertada, o elevador estiver parado sobe
        if (Input.GetKeyDown("u") && parado == true)
        {
            if (transform.position == primeiroAndar.transform.position)
            {
                subindo = true;
                descendo = false;
            }
        }

        if (Input.GetKeyDown("j") && parado == true)
        {
            if (transform.position == segundoAndar.transform.position)
            {
                subindo = false;
                descendo = true;
            }
        }
    }
}

