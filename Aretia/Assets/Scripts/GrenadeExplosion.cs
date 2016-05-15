﻿using UnityEngine;
using System.Collections;


namespace AretiaEngine {
public class GrenadeExplosion : MonoBehaviour {

private Collider[] hitColliders;
public float blastRadius;
public float explosionPower;
public LayerMask explosionLayers;

void OnCollisionEnter (Collision col){
	ExplosionWork(col.contacts[0].point);
}

void ExplosionWork (Vector3 explosionPoint) {
	hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

	foreach(Collider hitCol in hitColliders) {

		if(hitCol.GetComponent<NavMeshAgent>() != null) {
			hitCol.GetComponent<NavMeshAgent>().enabled = false;
		}

		//Debug.Log(hitCol.gameObject.name + "Grenade Collision");
		if(hitCol.GetComponent<Rigidbody>() != null) {
			hitCol.GetComponent<Rigidbody>().isKinematic = false;
			hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower, explosionPoint, blastRadius, 1, ForceMode.Impulse);
		}
	}

}

}
}