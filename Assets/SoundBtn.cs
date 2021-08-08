using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundBtn : MonoBehaviour
{
    [Header("Button Images")]
    [SerializeField] Sprite SoundOn;
    [SerializeField] Sprite SoundOff;
    [Header("Button")]
    [SerializeField] Button btn;
    bool soundState;
    
    void Awake(){
        soundState = PlayerPrefs.GetInt("SOUND_STATE") == 1;
        AudioListener.pause = soundState;
        if(soundState)
            btn.image.sprite = SoundOn;
        else
            btn.image.sprite = SoundOff;
    }
    public void ChangeButtonImage(){        
        //change button image
        if (soundState){
            //mute
            AudioListener.pause = soundState;
            btn.image.sprite = SoundOff;
            PlayerPrefs.SetInt("SOUND_STATE",0); 
            soundState = false;
        }else{
            //unmute
            AudioListener.pause = soundState;
            btn.image.sprite = SoundOn;
            PlayerPrefs.SetInt("SOUND_STATE",1);
            soundState = true;
        }
       //PlayerPrefs.SetInt("SOUND_STATE",soundState ? 1 : 0); 
       PlayerPrefs.Save();
    }
}
