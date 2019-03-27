using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    public GameObject timer;

    public void iniciar(){
        timer.SetActive(true);
    }
}
