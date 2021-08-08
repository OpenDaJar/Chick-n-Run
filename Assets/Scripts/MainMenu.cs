using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Sound Settings")]
    [SerializeField] Sprite SoundOn;
    [SerializeField] Sprite SoundOff;
    [SerializeField] Button SoundBtn;
    bool Sound;

    void Awake(){
        Screen.orientation = ScreenOrientation.Portrait;
        Sound = PlayerPrefs.GetInt("SOUND_STATE") == 1;
        if(Sound){
            AudioListener.pause = true;
            SoundBtn.image.sprite = SoundOn;
        }else{
            SoundBtn.image.sprite = SoundOff;
            AudioListener.pause = false;
        }
    }

    public void ChangeSound(){
        if(Sound){
            Sound = false;
            SoundBtn.image.sprite = SoundOff;
            AudioListener.pause = true;
        }else{
            Sound = true;
            SoundBtn.image.sprite = SoundOn;
            AudioListener.pause = false;
        }

    }
    public void ChangeScene(string name){
        PlayerPrefs.SetInt("SOUND_STATE", Sound ? 1:0);
        if(name == "GameLevel"){
            Debug.Log("Starting Game Level");
            Screen.orientation = ScreenOrientation.Landscape;
        }else{
            Screen.orientation = ScreenOrientation.Portrait;
        }
        SceneManager.LoadScene(name);

    }
}
