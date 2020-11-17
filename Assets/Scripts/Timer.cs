using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public string LevelToLoad;
    private float currentTime = 0f;
    private float startingTime = 10f;
    [SerializeField]
    Text timerDisplay;
    void Start()
    {
        //when the question starts the timer will say 10 
        currentTime = startingTime; 
    }

    // Update is called once per frame
    void Update()
    {
        //countdown function -1 each second
        currentTime -= 1 * Time.deltaTime;
        //shows the timer on the screen 
        timerDisplay.text = currentTime.ToString("0");

        //timerDisplay.color = Color.Red("3");
        
        //Stops timer at 0
        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        if (currentTime == 0)
        {
            //Goes to next Question if timer hits 0
            SceneManager.LoadScene(LevelToLoad);
            //when timer hits 0 it disappears
            //Destroy(timerDisplay.text);
        }
    }
}
