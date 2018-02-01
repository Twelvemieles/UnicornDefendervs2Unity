using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {
    private Rigidbody2D bulletRB;
    public int asteroidLife;
    public float bulletSpeed;
    public Sprite[] bulletSprite;
    private int i;
    void Awake()
    {
         bulletRB = GetComponent<Rigidbody2D>();
         i = Random.Range(0, bulletSprite.Length);
        GetComponent<SpriteRenderer>().sprite = bulletSprite[i];

    }
	// Use this for initialization
	void Start () {
        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = (Input.mousePosition - sp).normalized;
        bulletRB.AddForce(dir * bulletSpeed);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //cambia el sprite de la bala cuando choca con enemigos
        if (other.gameObject.tag == "Enemy")
        {
             i = Random.Range(0, bulletSprite.Length);
            GetComponent<SpriteRenderer>().sprite = bulletSprite[i];
        }
        // Update is called once per frame
    }
        void Update () {

        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
