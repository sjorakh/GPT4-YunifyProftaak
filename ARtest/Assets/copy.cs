using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy : MonoBehaviour {

	bool exists = false;
	public GameObject kurwa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!exists && gameObject.GetComponent<MeshRenderer>().isVisible) {
			GameObject kurwa2 = Instantiate (kurwa);
			kurwa2.transform.position = gameObject.transform.parent.transform.position;
			exists = true;
		}
	}
}
