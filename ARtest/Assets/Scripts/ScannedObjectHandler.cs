using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedObjectHandler : MonoBehaviour {

    public bool ScaleObject = false;
    public DefineRoom defineRoom;

    private bool scanned = false;
    private float timer = 1f;

    private float x;
    private float y;
    private float z;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(!scanned && gameObject.GetComponent<MeshRenderer>().isVisible)
        {
            //defineRoom.AddScannedObject(this);
            scanned = true;
            x = transform.rotation.x;
            y = transform.rotation.y;
            z = transform.rotation.z;
            
        }

        if (scanned)
        {
            transform.rotation = Quaternion.Euler(x, y, z);
        }

        //if (ScaleObject && timer <= 0)
        //{
        //    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 1, 1, gameObject.transform.localScale.z + 1);
        //}

        //if(timer <= 0)
        //{
        //    timer = 1f;
        //}
	}
}
