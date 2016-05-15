using UnityEngine;
using System.Collections;

namespace AretiaEngine {

public class EnemyChase : MonoBehaviour {

	private Transform myTransform;
	private NavMeshAgent myNavMeshAgent;
	private Collider[] hitColliders;
	private float checkRate;
	private float nextCheck;
	public LayerMask playerLayer;
	private float detectionRadius;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetInitialReferences {
		myTransform = transform;
		myNavMeshAgent = GetComponent<NavMeshAgent>();
		checkRate = Random.Range(0.8f, 1.2f);

	}



}


}