using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameControl : MonoBehaviour 
{

    public static GameControl Instance = null;
    
    public float scrollSpeed = -1.5f;
    public bool isGameOver = false;
    private int score = 0;
    public int best = 0;
    public Text bestScore;
    public Text scoreText;
    private bool IsTiming;  //Whether to start timing 
    public float time;
    public Text timeLeft;
    public float gameOvertime;
    public bool lifes = false;
    public Text gameOverText1;
    public int deathScore = 0;
    public Text lifesText;
    





    public GameObject countDown;
    public GameObject MainMenu;
    public GameObject columnDown;
    public GameObject Ninja;
    public GameObject LoginDate;
    public GameObject GameOver;
    public GameObject Lifes;
    public GameObject gameOverText;



    void Awake()
    {

        Instance = this;
    }

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;//or right for right landscape } 
        Time.timeScale = 0;
        Ninja.SetActive(false);
        countDown.SetActive(false);
        score = score + deathScore;
        scoreText.text = "Score: " + score;
        
        
        
        
        
        
    }



    // Update is called once per frame
    void Update () {
        time += Time.deltaTime;
        if (time > 0){
            timeLeft.text = "3";

        }
        if (time > 1)
        {
            timeLeft.text = "2";
        }
        if (time > 2)
        {
            timeLeft.text = "1";
        }
        if (time > 3)
        {
            timeLeft.text = "GO!";
        }

        if (time > 4)
        {
            countDown.SetActive(false);
        }


        

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }


    

    public void Score()
    {

        if (isGameOver) {return;}
        score++;
        scoreText.text = "Score: " + score;
    }
    
    
    public void Death() 
    {
        
        isGameOver = true;
        if (PlayerPrefs.GetFloat("BestScore") < score)
        {
            PlayerPrefs.SetFloat("BestScore", score);
        }
        GameOver.SetActive(true);
        gameOverText1.text = "GAME OVER!";
        Time.timeScale = 0;
        
        
        
       

    }

    

    public void Play()
    {
        Time.timeScale = 1;
        MainMenu.SetActive(false);
        Ninja.SetActive(true);
        countDown.SetActive(true);
        
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        
    }
    public void WatchAd()
    {
        lifes = true;
    }

    public void ResetPosition()
    {
        Ninja.GetComponent<Character>().enabled = false; //toggle this script to re-invoke it
        Ninja.GetComponent<Character>().enabled = true;
    }


    public void Quit()
    {

        Application.Quit();

    }


}
