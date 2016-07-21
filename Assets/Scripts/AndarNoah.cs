using UnityEngine;
using System.Collections;

public class AndarNoah : MonoBehaviour {

    public Transform Ponto;
    public GameObject Noah;
    NavMeshAgent AuxPosicaoNavMesh;
    Animation animacao;

    public bool check;


	// Use this for initialization
	void Start () {

        AuxPosicaoNavMesh = transform.GetComponent<NavMeshAgent>();

        animacao = Noah.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {

        AuxPosicaoNavMesh.destination = Ponto.position;

        //se o avatar estiver a 1 metro de distancia do ponto a animação para
        if(Vector3.Distance (Noah.transform.position, Ponto.transform.position) <= 1)
        {
           // animacao.Stop();
        }
	}
}
