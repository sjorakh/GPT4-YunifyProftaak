using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineRoom : MonoBehaviour {

    public List<GameObject> ScannedObjects = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScannedObject(ScannedObjectHandler scannedObject)
    {
        if(ScannedObjects.Count == 0)
        {
            //scannedObject.transform.localScale = new Vector3(100, 1, 100);
        }
        else
        {
            //Set scaling true
            scannedObject.ScaleObject = true;
        }
        ScannedObjects.Add(scannedObject.gameObject);
    }
}
