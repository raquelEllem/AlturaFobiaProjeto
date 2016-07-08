using UnityEngine;
using System.Collections;

public class EstadoNoah : MonoBehaviour {

	public float distancia;
	public float tempoParada;
	public int wp;
	public GameObject[] wayPoint;

	AENoah ANoah;
	public GameObject Noah;

	Animation animacao;


	// Use this for initialization
	void Start () {

		wp = 0;

		ANoah = GetComponent<AENoah>();
		animacao = Noah.GetComponent<Animation> ();
		tempoParada = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
		tempoParada += Time.deltaTime; //conta o tempo

		ANoah.NavMeshAgente.Resume (); //continua o caminho
		ANoah.NavMeshAgente.speed = 0.5F;
		ANoah.NavMeshAgente.acceleration = 0.2F;

		animacao.Play ("swagger_walk"); //animação para andar

		if (tempoParada <= 15) {
			if (wp <= wayPoint.Length - 1) {
				ANoah.NextPos = wayPoint [wp].transform; //segue para o próximo wp


				distancia = Vector3.Distance (transform.position, wayPoint [wp].transform.position);
				//se estiver a 1,5 metros do wp
				if (Vector3.Distance (transform.position, wayPoint [wp].transform.position) <= 0.1)
					wp = Random.Range (0, 3); //incrementa o wp
			}
		} else {
			tempoParada = 0;
		}

	}
}