using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI txtScore;
    bool Sound;
    string ScoreString;
    double ScoreNum;
    [SerializeField]GameObject Player;
    bool PlayerIsAlive;
    void Awake(){
        PlayerIsAlive = true;
        Screen.orientation = ScreenOrientation.Landscape;
        Sound = PlayerPrefs.GetInt("SOUND_STATE") == 1;
        ScoreString = PlayerPrefs.GetString("SCORE");
        if(Sound)
            AudioListener.pause = true;
        else
            AudioListener.pause = false;
        
    }
     void FixedUpdate()
    {   
        if(PlayerIsAlive){
        ScoreNum++;
        ScoreString = ScoreNum + "";
        txtScore.text = "Score: " + ScoreNum;
        PlayerPrefs.SetString("SCORE",ScoreString);
        }

    }
    void PlayerDied(){
        Debug.Log("Player Died");
        PlayerIsAlive = false;
    }
}
