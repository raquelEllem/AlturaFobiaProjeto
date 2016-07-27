using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

    public bool check;
    public Rigidbody rB;

    Collider colisao;


	// Use this for initialization
	void Start () {

        rB = transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //acelera a 9 m/s para frente
        rB.velocity = transform.forward * 9;

        //destroi bolas que não colidem com nada depois de 5 segundos
        Destroy(gameObject, 5);

        //se tiver qualquer coisa a 1 metro a frente do centro da bola (raycast)
        // a bola é destruida
        //if (Physics.Raycast(transform.position, transform.forward, 1))
        //{
        //    Destroy(gameObject);
        //}

	}

    //void OnCollisionEnter (Collision colisao) {

    //    //destroi bolas que colidem com alguma coisa
    //    //Destroy(gameObject);

    //    if (colisao.gameObject.tag == "alvo")
    //    {
    //        check = true;
    //    }

    //}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("alvo"))
        {
            check = true;
        }
    }

     
}

