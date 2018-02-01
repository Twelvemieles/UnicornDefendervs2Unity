using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
   
    public bool stop;
    private float elapsedTime;
    [SerializeField]
    private float time;
    [SerializeField]
    private Transform A, B, bossPoint;
    // Use this for initialization
   
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "barPoint")
        {
            stop = true;
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {


        if (!stop)
        {
        elapsedTime += Time.deltaTime;
        transform.position = Vector3.Lerp(A.position, B.position, elapsedTime / time);

        }

        if (Input.GetButtonDown("Fire2"))
        {
            TurnOnBar();
        }


    }

    public void TurnOnBar()
    {
        stop = false;
    }
}
