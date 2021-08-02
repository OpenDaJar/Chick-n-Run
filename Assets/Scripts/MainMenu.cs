using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start(){
        Screen.orientation = ScreenOrientation.Portrait;
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
