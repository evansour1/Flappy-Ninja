using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Text BestScore;
    
    void Start()
    {
        BestScore.text = "BEST: " + PlayerPrefs.GetFloat("BestScore");
        Time.timeScale = 0;
        Screen.orientation = ScreenOrientation.LandscapeLeft;//or right for right landscape } 

    }


    
   



}
