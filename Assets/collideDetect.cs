using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideDetect : MonoBehaviour {

    [SerializeField] GameObject SphereA;     //Refference of object
    [SerializeField] GameObject SphereB;
    Vector3 V1;
    Vector3 V2;
    Vector3 positionA;
    Vector3 positionB;
    float Ra;
    float Rb;
    float d;
	void Start () {
        V1 = new Vector3(-0.05f, 0, 0);
        V2 = new Vector3(0.05f, 0, 0);

        Ra = SphereA.GetComponent<Transform>().localScale.y/2;  //get the radius
        Rb = SphereB.GetComponent<Transform>().localScale.y/2;

        positionA = SphereA.GetComponent<Transform>().position;
        positionB = SphereB.GetComponent<Transform>().position;
        d = Mathf.Sqrt(Mathf.Pow(positionB.x - positionA.x, 2) + Mathf.Pow(positionB.y - positionA.y, 2) + Mathf.Pow(positionB.z - positionA.z, 2));
    }
	
	// Update is called once per frame
	void Update () {

        if(d > Ra + Rb) {           //if d smaller than Ra + Rb, stop the objects
            SphereA.GetComponent<Transform>().position = SphereA.GetComponent<Transform>().position + V1;   //V1

            SphereB.GetComponent<Transform>().position = SphereB.GetComponent<Transform>().position + V2;   //V2

            positionA = SphereA.GetComponent<Transform>().position;
            positionB = SphereB.GetComponent<Transform>().position;
        }

        d = Mathf.Sqrt(Mathf.Pow(positionB.x - positionA.x, 2) + Mathf.Pow(positionB.y - positionA.y, 2) + Mathf.Pow(positionB.z - positionA.z, 2));
        Debug.Log(Ra+Rb);       //debug the distance
    }
}
