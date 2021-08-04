using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        Screen.orientation = ScreenOrientation.Landscape;
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
