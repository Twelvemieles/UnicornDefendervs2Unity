using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColorAsteroid : MonoBehaviour {
   public SpriteRenderer renderer ;
    // Use this for initialization
    void Start () {

//renderer = gameObject.GetComponent(SpriteRenderer);
            
    }

    // Update is called once per frame
    void Update () {

        renderer.color = new Color(0f, 0f, 0f, 1f); // Set to opaque black

    }
}
