using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    public GameObject timer,pan;

    public void iniciar(){
        timer.SetActive(true);
        pan.SetActive(false);

    }
}
