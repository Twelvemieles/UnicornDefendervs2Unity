using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lifeScript : MonoBehaviour {

    public Transform asteroiDad;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = asteroiDad.position;

    }
}
