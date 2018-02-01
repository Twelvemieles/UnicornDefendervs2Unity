using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atackAnimation : MonoBehaviour {

    public Transform bulletSpawner;
    public GameObject bulletPrefab;
    public float fireRate;
    private float nextFire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        playerShooting();
	}
    public void playerShooting ()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation);

        }
    }
}
