using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scripTimer : MonoBehaviour
{
    public Text count;
    public Text end;
    public int speed;
    private float time = 5.0f;
    public GameObject PanelGameOver;
    public GameObject soundclock;
    public Button move;

    private bool bandera = true;


    // Update is called once per frame
    public void iniciar()
    {
       
        //play.onClick.AddListener();
        end.enabled=false;
        count.enabled=true;
        Debug.Log(time);

    }


    public void Update()
    {   
        if(bandera){
             time = (float)PlayerPrefs.GetInt("limit", 60);
             bandera = false;
        }
        time -= Time.deltaTime;
    
        if(time>=0){
        soundclock.SetActive(true); 
        //move.transform.RotateAround(transform.position, Vector3.back, speed * Time.deltaTime);   
        move.transform.RotateAround(move.transform.position, Vector3.back, speed * Time.deltaTime);
       // time -= Time.deltaTime;
        count.text= " "+ time.ToString("f0");
        //Debug.Log("gggg");
        if(time<=0){
            end.enabled=true;
            count.enabled=false;
        }
      }else
      {
           PanelGameOver.SetActive (true);
           soundclock.SetActive(false); 
      }
    }

}
