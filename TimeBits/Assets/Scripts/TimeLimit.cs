using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
     public void limit(){
        SceneManager.LoadScene(PlayerPrefs.GetString("style", "Figures"));
    }
}
