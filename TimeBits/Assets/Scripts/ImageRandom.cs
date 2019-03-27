using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageRandom : MonoBehaviour
{

    public GameObject[] sprite_pic;
    Stack<int> RandNums = new Stack<int>();
    private int rand;
    private Image[] fig = new Image[50];
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("style") == "Fruits")
        {
            string objeto;
            for (int i = 0; i < fig.Length; i++)
            {
                int randimg= Random.Range(0,50);
                objeto = i + 1 < 10 ? "F-0" + (i + 1).ToString() : "F-" + (i + 1).ToString();
                fig[i] = GameObject.Find(objeto).GetComponent<Image>();
                fig[i].sprite = Resources.Load<Sprite>("menu/Fruits/fbe" + randimg.ToString());
            }
        }
        else if (PlayerPrefs.GetString("style") == "Numbers")
        {
            string objeto;
            for (int i = 0; i < fig.Length; i++)
            {
                int randimg= Random.Range(0,50);
                objeto = i + 1 < 10 ? "F-0" + (i + 1).ToString() : "F-" + (i + 1).ToString();
                fig[i] = GameObject.Find(objeto).GetComponent<Image>();
                fig[i].sprite = Resources.Load<Sprite>("menu/Numbers/nbe" + randimg.ToString());
            }
        }
        else if (PlayerPrefs.GetString("style", "Figures") == "hallowin")
        {
            string objeto;
            for (int i = 0; i < fig.Length; i++)
            {
                int randimg= Random.Range(0,50);
                objeto = i + 1 < 10 ? "F-0" + (i + 1).ToString() : "F-" + (i + 1).ToString();
                fig[i] = GameObject.Find(objeto).GetComponent<Image>();
                fig[i].sprite = Resources.Load<Sprite>("Particules/Halloween/hbe" + randimg.ToString());
            }
        }
        else
        {
             string objeto;
             
            for (int i = 0; i < fig.Length; i++)
            {
                int randimg= Random.Range(1,51);
                objeto = i + 1 < 10 ? "F-0" + (i + 1).ToString() : "F-" + (i + 1).ToString();
                fig[i] = GameObject.Find(objeto).GetComponent<Image>();
                fig[i].sprite = Resources.Load<Sprite>("Menu/Shapes/F-" +  randimg.ToString());
            }
             
        }



        change();
    }

    void change()
    {
        float[,] positions = new float[sprite_pic.Length,3]; 
        for(int i=0; i<sprite_pic.Length; i++){
            positions[i,0] = sprite_pic[i].transform.position.x;
            positions[i,1] = sprite_pic[i].transform.position.y;
            positions[i,2] = sprite_pic[i].transform.position.z;
        }
        for (int i = 0; i < sprite_pic.Length; i++)
        {
            do
            {
                rand = Random.Range(0, sprite_pic.Length);

            } while (RandNums.Contains(rand)) ;
            RandNums.Push(rand);
            sprite_pic[i].transform.position = new Vector3(positions[rand,0], positions[rand,1], positions[rand,2]);
        }
    }
}
