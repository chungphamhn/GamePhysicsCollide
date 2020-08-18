using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {

            GetComponent<Transform>().position = new Vector3(1, 2, 3);              //change position
            GetComponent<Transform>().localScale = new Vector3(3, 4, 5);         //change scale
        }
	}
}
