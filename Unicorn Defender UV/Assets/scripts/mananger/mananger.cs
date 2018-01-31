using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mananger : MonoBehaviour {
    public int A;
    public int B;
    public int damage;
    public int RangeLife;
    public GameObject gameOverText;
    public bool gameOver;
    public int score;
    public Text ScoreText;
	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
        
        gameOver = false;
        StartCoroutine(AsteroidRange());
        gameOverText.SetActive(false);
        ScoreText.gameObject.SetActive(true);
    }
	
    public void AddScore (int value)
    {
        score += value;
        UpdateScore();
    }
	// Update is called once per frame
	void Update () {
		if (gameOver)
        {
            GameOver();
        }
	}
    //cambiar el rango de la vida de los asteroides
    IEnumerator AsteroidRange()
    {

        while (true)
        {
           
            A += RangeLife;
            B += RangeLife;
            yield return new WaitForSeconds(6);
        }
    }

    void UpdateScore()
    {
        ScoreText.text = "" + score;
    }

    public void GameOver() //esto hace aparecer el menú de perder
    {
        gameOverText.SetActive(true);
        ScoreText.gameObject.SetActive(false);
    }
}
