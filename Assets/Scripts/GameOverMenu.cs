using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameOverMenu : MonoBehaviour
{
    [Header("Scores")]
    //[SerializeField] TextMeshProUGUI txtScore;
    [SerializeField] Text txtScore;
    //[SerializeField] TextMeshProUGUI txtHighScore;
    [SerializeField] Text txtHighScore;
    string Score, Highscore;
    double ScoreNum,HighscoreNum;
    bool Sound;

    // Start is called before the first frame update
    void Awake(){

        Screen.orientation = ScreenOrientation.Landscape;
        //Score/Highscore
        Score = PlayerPrefs.GetString("SCORE");
        Highscore = PlayerPrefs.GetString("HIGHSCORE");
        if(Highscore == "")
            Highscore = "0";
        Double.TryParse(Highscore, out HighscoreNum);
        Double.TryParse(Score, out ScoreNum);
        if(HighscoreNum < ScoreNum)
            Highscore = Score;
        
        txtScore.text ="Score: " + Score;
        PlayerPrefs.SetString("SCORE",Score);
        txtHighScore.text ="Highscore: " + Highscore;
        PlayerPrefs.SetString("HIGHSCORE",Highscore);
        //Sound
        Sound = PlayerPrefs.GetInt("SOUND_STATE") == 1;
        if(Sound)
            AudioListener.pause = true;
        else
            AudioListener.pause = false;
    }
    public void ChangeScene(string name){
        if(name == "GameLevel"){
            Debug.Log("Starting Game Level");
            Screen.orientation = ScreenOrientation.Landscape;
        }else{
            Screen.orientation = ScreenOrientation.Portrait;
        }
        SceneManager.LoadScene(name);

    }
}
