using UnityEngine;
using System.Collections;

public class UpElevator : MonoBehaviour {

    public bool subindo;
    public bool descendo;
    public bool parado;

    public bool check;

    public Transform paradaBaixo;
    public Transform paradaAlta;

    public float speed;

    public GameObject botao;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (subindo == true)
        {
            //transform.position = Vector3.MoveTowards(transform.position, paradaAlta.transform.position, speed * Time.deltaTime);
            transform.Translate(0, 1, 0);
        }
	    
        if (descendo == true)
        {
            //transform.position = Vector3.MoveTowards(transform.position, paradaBaixo.transform.position, speed * Time.deltaTime);
            transform.Translate(0, -1, 0);
        }

        if (transform.position == paradaBaixo.transform.position || transform.position == paradaAlta.transform.position)
        {
            botao.GetComponent<Renderer>().materials[0].color = Color.red;
            parado = true;
        }else
        {
            botao.GetComponent<Renderer>().materials[0].color = Color.green;
            parado = false;
        }

        if (Input.GetKeyDown("e") && parado == true)
        {
            if (transform.position == paradaBaixo.transform.position)
            {
                subindo = true;
                descendo = false;
            }

            if (transform.position == paradaAlta.transform.position)
            {
                subindo = false;
                descendo = true;
            } 
        }

	}
}
