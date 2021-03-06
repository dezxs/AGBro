﻿using UnityEngine;
using System.Collections;

namespace AretiaEngine {

public class ThrowGrenade : MonoBehaviour {

public GameObject grenadePrefab;
private Transform myTransform;
public float prop;

	// Use this for initialization
	void Start () {
	SetInitialReferences();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")){
			SpawnGrenade();
		}
	}

	void SetInitialReferences(){

		myTransform = transform;
	}

	void SpawnGrenade(){

		GameObject go = (GameObject) Instantiate(grenadePrefab, myTransform.TransformPoint(2,2, 0.5f), myTransform.rotation);
		go.GetComponent<Rigidbody>().AddForce(myTransform.forward * prop, ForceMode.Impulse);
		Destroy(go, 10);
	}


}


}