using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStyles : MonoBehaviour
{
    public void figures(){
        PlayerPrefs.SetString("style", "Figures");
        SceneManager.LoadScene("Menu");
    }

    public void fruits(){
        PlayerPrefs.SetString("style", "Fruits");
        SceneManager.LoadScene("Menu");
    }
     public void numbers(){
        PlayerPrefs.SetString("style", "Numbers");
        SceneManager.LoadScene("Menu");
    }
    public void hallowin(){
        PlayerPrefs.SetString("style", "hallowin");
        SceneManager.LoadScene("Menu");
    }

}