using UnityEngine;
using System.Collections;

public class ElevadorSobeTempo : MonoBehaviour {

    // controla a velocidades do elevador
    public float VelocidadeAceleracao;
    public float VelocidadeAtual;
    public float VelocidadeDesaceleracao;
    public float VelocidadeMax;

    // controle
    public bool subir;
    public bool parar;

    // Use this for initialization
    void Start () {
        subir = false;
        parar = false;

	}
	
	// Update is called once per frame
	void Update () {
	
        // se clicar no 'u' começa a subir
        if (Input.GetKeyDown("e"))
        {
            subir = true;
            parar = false;
        }

        // se clicar 'p' para a subida
        if (Input.GetKeyDown("p"))
        {
            parar = true;
            subir = false;
        }

        //continua acelerando e subindo
        if (subir == true)
        {
            transform.Translate(0, VelocidadeAtual, 0);
            VelocidadeAtual = VelocidadeAtual + VelocidadeAceleracao / 10 * Time.deltaTime;
        }

        //começa a desacelerar e para
        if(parar == true)
        {
            VelocidadeAtual = VelocidadeAtual - VelocidadeDesaceleracao * Time.deltaTime;
            transform.Translate(0, 0, 0);

        }

        //limita a velocidade
        if (VelocidadeAtual > VelocidadeMax)
        {
            VelocidadeAtual = VelocidadeMax;
        }

        //não deixa descer
        if (VelocidadeAtual < 0)
        {
            VelocidadeAtual = 0;
        }

	}
}
