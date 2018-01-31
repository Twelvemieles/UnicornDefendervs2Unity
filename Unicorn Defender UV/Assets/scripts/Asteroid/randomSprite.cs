using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSprite : MonoBehaviour {

    public Sprite[] asteroidSprite;
    private int i ;
	// Use this for initialization
	void Awake () {
        i = Random.Range(0, 2);
        GetComponent<SpriteRenderer>().sprite = asteroidSprite[i];

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
