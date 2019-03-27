using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag == "quad"){
            Debug.Log("Es quad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
