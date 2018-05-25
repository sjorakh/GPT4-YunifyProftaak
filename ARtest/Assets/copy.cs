using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy : MonoBehaviour {

    public GameObject prefab;
    private bool exists = false;

    public Camera ARCamera;
    public Camera GameCamera;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!exists && gameObject.GetComponent<MeshRenderer>().isVisible) {
			GameObject scannedPoint = Instantiate (prefab);
            scannedPoint.transform.position = transform.parent.transform.position;
			exists = true;

            ARCamera.GetComponent<VuforiaMonoBehaviour>().enabled = false;
            //GameCamera.gameObject.SetActive(true);
            //ARCamera.gameObject.SetActive(false);
            
		}
	}
}
