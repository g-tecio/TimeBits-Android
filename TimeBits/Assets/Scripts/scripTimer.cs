using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scripTimer : MonoBehaviour
{
    public Text count;
    public Text end;
    float speed;
    private float time = 5.0f;
    public GameObject PanelGameOver;
    public GameObject CargarEscena;
    public GameObject soundclock;
    public GameObject win, panel1;
    public Button move;

    private bool bandera = true;
    public void iniciar()
    {
        end.enabled = false;
        count.enabled = true;
        Debug.Log(time);
    }


    public void Update()
    {
        if (bandera)
        {
            time = (float)PlayerPrefs.GetInt("limit", 60);
            speed = (360.0f / time);
            bandera = false;
        }
        if (!win.activeSelf)
        {
            time -= Time.deltaTime;

            if (time >= 0)
            {
                soundclock.SetActive(true);
                move.transform.RotateAround(move.transform.position, Vector3.back, speed * Time.deltaTime);
                count.text = " " + time.ToString("f0");
                if (time <= 0)
                {
                    end.enabled = true;
                    count.enabled = false;
                    panel1.SetActive(true);
                }
            }
            else
            {
               
                PanelGameOver.SetActive(true);
                soundclock.SetActive(false);
                panel1.SetActive(true);
            }
        }
        else
        {
            soundclock.SetActive(false);
        }
    }

}
