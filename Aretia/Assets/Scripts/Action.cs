using UnityEngine;
using System.Collections;

namespace AretiaEngine
{
public class Action : MonoBehaviour {

private float actionRate = 0.3f;
private float nextAction;
private RaycastHit hit;
private float range = 300;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckForInput();
	}

	void CheckForInput() {
		if(Input.GetButton("Fire1") && Time.time > nextAction){
			nextAction = Time.time + actionRate;
			Debug.Log("Key Pressed");
			Debug.DrawRay(transform.position, transform.forward, Color.red, 3);
			if(Physics.Raycast(transform.position,transform.forward, out hit, range)){
				if(hit.transform.CompareTag("Enemy")){
					Debug.Log("Enemy" + hit.transform.name);

				}
			}
		}
			
	}
}
}