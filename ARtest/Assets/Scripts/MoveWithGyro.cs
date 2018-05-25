using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveWithGyro : MonoBehaviour {

    private GameObject camParent;

	// Use this for initialization
	void Start () {
        camParent = new GameObject("CamParent");
        camParent.transform.position = this.transform.position;
        this.transform.parent = camParent.transform;
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.activeSelf && gameObject.GetComponent<VuforiaMonoBehaviour>().enabled == false)
        {
            camParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
            this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
        }
    }
}
