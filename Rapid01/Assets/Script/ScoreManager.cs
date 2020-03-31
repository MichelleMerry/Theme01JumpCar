using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score, highScore;

    public Text scoreText, highScoreText;



    public void Awake()
    {
        instance = this;
    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore()
    {
        score++;

        UpdateHighScore();

        scoreText.text = score.ToString();

    }

    public void UpdateHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
        }
        // highScoreText.text = highScore.ToString();
    }

    public void ResetScore()
    {
        score = 0;
    }



}
