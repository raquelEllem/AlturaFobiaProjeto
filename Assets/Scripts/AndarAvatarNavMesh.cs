using UnityEngine;
using System.Collections;

public class AndarAvatarNavMesh : MonoBehaviour {

    public Transform Ponto;
    public GameObject Avatar;
    NavMeshAgent AuxPosicaoNavMesh;
    Animation animacao;

    public bool check;


	// Use this for initialization
	void Start () {

        AuxPosicaoNavMesh = transform.GetComponent<NavMeshAgent>();

        animacao = Avatar.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {

        AuxPosicaoNavMesh.destination = Ponto.position;

        //se o avatar estiver a 1 metro de distancia do ponto a animação para
        if(Vector3.Distance (Avatar.transform.position, Ponto.transform.position) <= 1)
        {
           // animacao.Stop();
        }
	}
}
