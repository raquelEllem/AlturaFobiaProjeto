using UnityEngine;
using System.Collections;

public class Carro : MonoBehaviour {
    
    // controla as velocidades 
    public float VelocidadeAtual;
    public float VelocidadeAceleracao;
    public float VelocidadeDesaceleracao;
    public float VelocidadeMax;
    float tempo;


    bool andar;

    // Use this for initialization
    void Start () {

        andar = false;
	}
	
	// Update is called once per frame
	void Update () {

        //tempo += Time.deltaTime;

        //if (tempo > 5)
        //{
        //    andar = true;
        //}

        if (Input.GetKeyDown("c"))
        {
            andar = true;
        }

        if (andar == true)
        {
            VelocidadeAtual = VelocidadeAtual + VelocidadeAceleracao * Time.deltaTime;
            transform.Translate(VelocidadeAtual, 0, 0);
        }

        //evitar que o carro vá para tras a qualquer momento
        if (VelocidadeAtual < 0)
        {
            VelocidadeAtual = 0;
        }

        if (VelocidadeAtual >= VelocidadeMax)
        {
            VelocidadeAtual = VelocidadeMax;
        }

    }
}
