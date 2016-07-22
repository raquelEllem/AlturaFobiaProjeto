using UnityEngine;
using System.Collections;

public class AndarCarroCidade : MonoBehaviour {

    public Transform Ponto;
    public GameObject Carro;
    NavMeshAgent AuxPosicaoNavMesh;
    Animation animacao;

  
    // Use this for initialization
    void Start()
    {
        AuxPosicaoNavMesh = transform.GetComponent<NavMeshAgent>();

        animacao = Carro.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        AuxPosicaoNavMesh.destination = Ponto.position;

  
    }
}