using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeMP : MonoBehaviour
{
 
    public Text timeString;
    public int timeS;

    void Start()
    {
        if (PlayerPrefs.GetInt("limit")==0)
        {
            PlayerPrefs.SetInt("limit", 60);
        }
        timeS = PlayerPrefs.GetInt("limit");
        SelectTime(timeS);
    }

    public void minus(){
        if(PlayerPrefs.GetInt("limit") > 30){
            PlayerPrefs.SetInt("limit", PlayerPrefs.GetInt("limit") - 10);
            SelectTime(PlayerPrefs.GetInt("limit"));
        }
    }

    public void plus(){
        if(PlayerPrefs.GetInt("limit") < 90){
            PlayerPrefs.SetInt("limit", PlayerPrefs.GetInt("limit") + 10);
            SelectTime(PlayerPrefs.GetInt("limit"));
        }
    }

    private void SelectTime(int time){
        switch(time){
            case 30:
                timeString.text = "0 0 : 3 0";
                break;
            case 40:
                timeString.text = "0 0 : 4 0";
                break; 
            case 50:
                timeString.text = "0 0 : 5 0";
                break;
            case 60:
                timeString.text = "0 1 : 0 0";
                break;
            case 70:
                timeString.text = "0 1 : 1 0";
                break;
            case 80:
                timeString.text = "0 1 : 2 0";
                break;
            case 90:
                timeString.text = "0 1 : 3 0";
                break;
        }
    }
}