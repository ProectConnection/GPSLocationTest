using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassRotator : MonoBehaviour {

    Transform rotationObject;
    float rotation_Yaw;
    [SerializeField]
    uint rotationSplit_num = 36;
    float rotationSplitDegrees;
	// Use this for initialization
	void Start () {
        rotationObject = gameObject.transform;
        Input.compass.enabled = true;
        rotationSplitDegrees = (360f / rotationSplit_num);
    }
	// Update is called once per frame
	void Update () {
        //Input.location.Start();
        rotation_Yaw = Input.compass.trueHeading;
        if (rotationSplitDegrees == 0) rotation_Yaw = 0;
        else rotation_Yaw = (Mathf.Floor(rotation_Yaw / rotationSplitDegrees) * rotationSplitDegrees);
        rotationObject.parent.rotation = Quaternion.Euler(rotationObject.parent.rotation.x, rotation_Yaw, rotationObject.parent.rotation.z);
        //rotationObject.rotation = Quaternion.AngleAxis(Input.compass.magneticHeading, rotationObject.parent.position);
        
        //rotationObject.rotation = Quaternion.;
    }
}
