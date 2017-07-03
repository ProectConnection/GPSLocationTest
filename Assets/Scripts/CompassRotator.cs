using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassRotator : MonoBehaviour {

    Transform rotationObject;

	// Use this for initialization
	void Start () {
        rotationObject = gameObject.transform;
        Input.compass.enabled = true;
    }
	// Update is called once per frame
	void Update () {
        //Input.location.Start();
        rotationObject.parent.rotation = Quaternion.Euler(rotationObject.parent.rotation.x, Input.compass.trueHeading, rotationObject.parent.rotation.z);
        //rotationObject.rotation = Quaternion.AngleAxis(Input.compass.magneticHeading, rotationObject.parent.position);
        
        //rotationObject.rotation = Quaternion.;
    }
}
