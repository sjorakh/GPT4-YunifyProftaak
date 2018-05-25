using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour {

    public Text rotationText;
    public static GameObject Capsule;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Capsule != null)
        {
            rotationText.text = "X:" + Capsule.transform.rotation.x;
        }
	}
}
