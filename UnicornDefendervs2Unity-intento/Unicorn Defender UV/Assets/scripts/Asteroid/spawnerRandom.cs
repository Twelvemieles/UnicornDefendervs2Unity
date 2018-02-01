using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerRandom : MonoBehaviour {

    public GameObject asteroid;
    public int hazardCount;
    public float spawnWait;
    private bool gameOvered;
    public mananger scriptPc;
    private bool stop;
    private Arrow bar;
    // Use this for initialization
    void Start () {
       StartCoroutine( AsteroidRespawn());
        bar = GameObject.Find("arrowBoss").GetComponent<Arrow>();
        scriptPc = GameObject.Find("PC").GetComponent<mananger>();
    }
	
	// Update is called once per frame
	void Update () {
        stop = bar.stop;
        
        gameOvered = scriptPc.gameOver;
    }

     IEnumerator AsteroidRespawn()
    {
        
       while (true )
        {
            for (int i = 0; i < hazardCount; i++)
            {
                if (stop)
                {
                    break;
                }
                switch (Random.Range(3, 3))
                {
                    case 1:
                        Vector3 randomSpawn1 = new Vector3(Random.Range(-7f, -3f), Random.Range(-15f, 7f), 0f);
                        Instantiate(asteroid, randomSpawn1, transform.rotation);
                        break;
                    case 2:
                        Vector3 randomSpawn2 = new Vector3(Random.Range(-7.6f, 9.16f), Random.Range(2.12f, 9.16f), 0f);
                        Instantiate(asteroid, randomSpawn2, transform.rotation);
                        break;
                    case 3:
                        Vector3 randomSpawn3 = new Vector3(Random.Range(4.9f, 9.16f), Random.Range(-17.7f, 9.49f), 0f);
                        Instantiate(asteroid, randomSpawn3, transform.rotation);
                        break;
                    case 4:
                        Vector3 randomSpawn4 = new Vector3(Random.Range(-8.58f, 13.11f), Random.Range(-18.28f, -10.5f), 0f);
                        Instantiate(asteroid, randomSpawn4, transform.rotation);
                        break;
                }
            }

            yield return new WaitForSeconds(spawnWait);


            
            

            if (gameOvered)
            {
                break;
            }
        }
    }
}
