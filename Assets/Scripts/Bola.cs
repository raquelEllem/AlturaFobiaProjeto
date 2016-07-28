using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

    public Rigidbody rB;
    public int aux;
    public bool check;


	// Use this for initialization
	void Start () {
        aux = 0;

        rB = transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        //acelera a 9 m/s para frente
        rB.velocity = transform.forward * 9;

        //destroi bolas que não colidem com nada depois de 2 segundos
        Destroy(gameObject, 2);

        //se tiver qualquer coisa a 1 metro a frente do centro da bola (raycast)
        // a bola é destruida
        //if (Physics.Raycast(transform.position, transform.forward, 1))
        //{
        //    Destroy(gameObject);
        //}
	}

    void OnCollisionEnter(Collision colisao)
    {

        //destroi bolas que colidem com alguma coisa
        //Destroy(gameObject);

        if (colisao.gameObject.tag == "alvo")
        {
              //Destroy(gameObject);
            gameObject.GetComponent<Renderer>().materials[0].color = Color.blue;
            aux = aux + 1; 
            
            //se acertar 3 bolinhas no alvo chama a próxima cena
            if (aux == 3)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("ponte-fase3"); 
            }
        }

      

    }




}

