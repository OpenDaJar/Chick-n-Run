using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text txtScore;
    string CurrentScore;
    double score;
    string Highscore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score++;
        CurrentScore = "Score: " + score;
        txtScore.text = CurrentScore;
        PlayerPrefs.SetString("SCORE",CurrentScore);
    }
}
