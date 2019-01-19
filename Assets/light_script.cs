using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Light>().enabled = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Light>().enabled = false;
        }
	}
}
