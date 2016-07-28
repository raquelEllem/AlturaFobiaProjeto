using UnityEngine;
using System.Collections;

public class AndarCarroCidade : MonoBehaviour {

    public Transform Ponto1;
    public Transform Ponto2;

    public bool check;

    public GameObject Carro;
    NavMeshAgent AuxPosicaoNavMesh;
    Animation animacao;

    public Rigidbody rB;


    // Use this for initialization
    void Start()
    {
        rB = transform.GetComponent<Rigidbody>();

        AuxPosicaoNavMesh = transform.GetComponent<NavMeshAgent>();

        animacao = Carro.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        AuxPosicaoNavMesh.destination = Ponto1.position;

        if (check == true)
        {
            AuxPosicaoNavMesh.destination = Ponto2.position;
        }
    }

    void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.tag == "parada1")
        {
            check = true;
        }


    }
}