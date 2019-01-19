using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    float scrollSize = 5;
	// Use this for initialization
	void Start () {
         //offset=transform.position-palyer.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        // transform.position = offset + palyer.transform.position;
   
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            scrollSize -= 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            scrollSize += 1;
        }
        GetComponent<Camera>().orthographicSize = scrollSize;
    }
}
