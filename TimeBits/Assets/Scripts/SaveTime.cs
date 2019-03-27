using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveTime : MonoBehaviour
{
    // Start is called before the first frame update
     public void time(){
        PlayerPrefs.GetString("limit");
    }
}
