using UnityEngine;
using System.Collections;

public class AENoah : MonoBehaviour {

	public NavMeshAgent NavMeshAgente;
	public Transform NextPos;

	// Use this for initialization
	void Start () {
		
		NavMeshAgente = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		//Encontra o melhor caminho para chegar ao destino
		NavMeshAgente.destination = NextPos.position; 
	}
}
