using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lifeScript : MonoBehaviour {

    Vector3 Rotacion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Rotacion = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0);

    }
}
