using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class asteroidMovement : MonoBehaviour {

    public Text lifeText;
    
   
    private float rotate;
    public GameObject padre;
    private mananger scriptPc;
    private int asteroidLifeA , asteroidLifeB , life, damaged;
    
   
    // Use this for initialization
    void Awake()
    {
        rotate = Random.Range(-3, 3);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            scriptPc = GameObject.Find("PC").GetComponent<mananger>();
            damaged = scriptPc.damage;
            life -= damaged;
            // para refrescar el texto de vidas
            Updatelife();
        }
    }
    void Start()
    {
      scriptPc = GameObject.Find("PC").GetComponent<mananger>();
        asteroidLifeA = scriptPc.A;
        asteroidLifeB = scriptPc.B;
        life = Random.Range(asteroidLifeA, asteroidLifeB);
        // para refrescar el texto de vidas
        Updatelife();
        

    }
    // Update is called once per frame
    void Update()
    {
       
       
        transform.Rotate(new Vector3(0f, 0f, rotate));
       
     if (life <= 0 )
        {
            scriptPc.AddScore(1);
            Destroy(padre);
        }   
    }
    void Updatelife()
    {
        lifeText.text = "" + life;
    }

}