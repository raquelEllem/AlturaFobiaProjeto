using UnityEngine;
using System.Collections;

public class AndarCarro : MonoBehaviour {

    public Transform Ponto;
    public GameObject Carro1;
    NavMeshAgent AuxPosicaoNavMesh;
    Animation animacao;

    public bool check;


    // Use this for initialization
    void Start()
    {
        AuxPosicaoNavMesh = transform.GetComponent<NavMeshAgent>();

        animacao = Carro1.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        AuxPosicaoNavMesh.destination = Ponto.position;
	}
}
