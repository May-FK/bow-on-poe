using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answers : MonoBehaviour
{
    //public string LevelToLoad;

    public void rightAnswer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void wrongAnswer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
