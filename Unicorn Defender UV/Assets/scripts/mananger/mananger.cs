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
        RangeLife = 5;
        gameOver = false;
        gameOverText.SetActive(true);
        ScoreText.gameObject.SetActive(true);
    }
	
    public void AddScore (int value)
    {
        score += value;
        UpdateScore();
    }
	// Update is called once per frame
	void Update () {
		
	}
    //cambiar el rango de la vida de los asteroides
    IEnumerator AsteroidRange()
    {

        while (true)
        {
            yield return new WaitForSeconds(6);
            A += RangeLife;
            B += RangeLife;

        }
    }

    void UpdateScore()
    {
        ScoreText.text = "" + score;
    }

    public void GameOver() //esto hace aparecer el menú de perder
    {
        gameOverText.SetActive(true);
        gameOver = true;
        ScoreText.gameObject.SetActive(false);
    }
}
