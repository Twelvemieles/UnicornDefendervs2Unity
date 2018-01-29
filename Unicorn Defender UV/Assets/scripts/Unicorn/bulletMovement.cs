using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {
    private Rigidbody2D bulletRB;
    public int asteroidLife;
    public float bulletSpeed;

    void Awake()
    {
         bulletRB = GetComponent<Rigidbody2D>();
       
       
    }
	// Use this for initialization
	void Start () {
        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = (Input.mousePosition - sp).normalized;
        bulletRB.AddForce(dir * bulletSpeed);
    }
	
	// Update is called once per frame
	void Update () {

        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
