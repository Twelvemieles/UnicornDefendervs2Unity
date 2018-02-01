using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followUnicorn : MonoBehaviour {
    public GameObject target;
    public float moveSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        
    }
}
