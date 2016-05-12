using UnityEngine;
using System.Collections;

namespace AretiaEngine {

public class Detection : MonoBehaviour {

private RaycastHit hit;
public LayerMask detectionLayer;
private float checkRate = 0.5f;
private float nextCheck;
private Transform myTransform;
private float range = 10;

	// Use this for initialization
	void Start () {
		SetInitialReferences();
	}
	
	// Update is called once per frame
	void Update () {
		DetectItems();
	}

	void SetInitialReferences() {
		myTransform = transform;
	}

	void DetectItems(){
		if(Time.time > nextCheck){
			nextCheck = Time.time + checkRate;

			if(Physics.Raycast(myTransform.position, myTransform.forward, out hit, range, detectionLayer)){
				Debug.Log(hit.transform.name + "is an item");
			}
		}
	}
}
}