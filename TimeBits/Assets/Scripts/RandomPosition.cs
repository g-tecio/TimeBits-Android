using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPosition : MonoBehaviour
{
    public Button BananaGreen, BananaRed, BananaOrange, BananaYellow, BananaPurple, maGreen, maRed, maOrange, maYellow, maPurple, uvaGreen, uvaRed, uvaOrange, uvaYellow, uvaPurple, straGreen, straRed, straOrange, straYellow, straPurple, LemonGreen,LemonRed, LemonOrange, LemonYellow, LemonPurple;

    int tam = 25;
    float[,] positions = new float[25, 3];
    Stack<int> numbers = new Stack<int>();


    // Start is called before the first frame update
    void Start()
    {
        fillArray();
        int Rand = Random.Range(0, tam);
        numbers.Push(Rand);
        BananaGreen.transform.position = new Vector3(positions[Rand,0],positions[Rand,1], positions[Rand,2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand)) 
        {

            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        BananaRed.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        BananaOrange.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        BananaYellow.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        BananaPurple.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);




        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        maRed.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        maOrange.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        maYellow.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        maPurple.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        maGreen.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);



        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        uvaRed.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        uvaOrange.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        uvaYellow.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        uvaPurple.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);


        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        uvaGreen.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);


        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        straRed.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        straOrange.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        straYellow.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        straPurple.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);


        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        straGreen.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        LemonRed.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        LemonOrange.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        LemonYellow.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);

        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        LemonPurple.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);


        Rand = Random.Range(0, tam);
        while (numbers.Contains(Rand))
        {
            Rand = Random.Range(0, tam);
        }
        numbers.Push(Rand);
        LemonGreen.transform.position = new Vector3(positions[Rand, 0], positions[Rand, 1], positions[Rand, 2]);
    }

    void fillArray()
    {
        positions[0, 0] = BananaGreen.transform.position.x;
        positions[0, 1] = BananaGreen.transform.position.y;
        positions[0, 2] = BananaGreen.transform.position.z;

        positions[1, 0] = BananaRed.transform.position.x;
        positions[1, 1] = BananaRed.transform.position.y;
        positions[1, 2] = BananaRed.transform.position.z;

        positions[2, 0] = BananaOrange.transform.position.x;
        positions[2, 1] = BananaOrange.transform.position.y;
        positions[2, 2] = BananaOrange.transform.position.z;

        positions[3, 0] = BananaYellow.transform.position.x;
        positions[3, 1] = BananaYellow.transform.position.y;
        positions[3, 2] = BananaYellow.transform.position.z;

        positions[4, 0] = BananaPurple.transform.position.x;
        positions[4, 1] = BananaPurple.transform.position.y;
        positions[4, 2] = BananaPurple.transform.position.z;


        positions[5, 0] = maGreen.transform.position.x;
        positions[5, 1] = maGreen.transform.position.y;
        positions[5, 2] = maGreen.transform.position.z;

        positions[6, 0] = maRed.transform.position.x;
        positions[6, 1] = maRed.transform.position.y;
        positions[6, 2] = maRed.transform.position.z;

        positions[7, 0] = maOrange.transform.position.x;
        positions[7, 1] = maOrange.transform.position.y;
        positions[7, 2] = maOrange.transform.position.z;

        positions[8, 0] = maYellow.transform.position.x;
        positions[8, 1] = maYellow.transform.position.y;
        positions[8, 2] = maYellow.transform.position.z;

        positions[9, 0] = maPurple.transform.position.x;
        positions[9, 1] = maPurple.transform.position.y;
        positions[9, 2] = maPurple.transform.position.z;

        positions[10, 0] = uvaGreen.transform.position.x;
        positions[10, 1] = uvaGreen.transform.position.y;
        positions[10, 2] = uvaGreen.transform.position.z;

        positions[11, 0] = uvaRed.transform.position.x;
        positions[11, 1] = uvaRed.transform.position.y;
        positions[11, 2] = uvaRed.transform.position.z;

        positions[12, 0] = uvaOrange.transform.position.x;
        positions[12, 1] = uvaOrange.transform.position.y;
        positions[12, 2] = uvaOrange.transform.position.z;

        positions[13, 0] = uvaYellow.transform.position.x;
        positions[13, 1] = uvaYellow.transform.position.y;
        positions[13, 2] = uvaYellow.transform.position.z;

        positions[14, 0] = uvaPurple.transform.position.x;
        positions[14, 1] = uvaPurple.transform.position.y;
        positions[14, 2] = uvaPurple.transform.position.z;

        positions[15, 0] = straGreen.transform.position.x;
        positions[15, 1] = straGreen.transform.position.y;
        positions[15, 2] = straGreen.transform.position.z;

        positions[16, 0] = straRed.transform.position.x;
        positions[16, 1] = straRed.transform.position.y;
        positions[16, 2] = straRed.transform.position.z;

        positions[17, 0] = straOrange.transform.position.x;
        positions[17, 1] = straOrange.transform.position.y;
        positions[17, 2] = straOrange.transform.position.z;

        positions[18, 0] = straYellow.transform.position.x;
        positions[18, 1] = straYellow.transform.position.y;
        positions[18, 2] = straYellow.transform.position.z;

        positions[19, 0] = straPurple.transform.position.x;
        positions[19, 1] = straPurple.transform.position.y;
        positions[19, 2] = straPurple.transform.position.z;

        positions[20, 0] = LemonGreen.transform.position.x;
        positions[20, 1] = LemonGreen.transform.position.y;
        positions[20, 2] = LemonGreen.transform.position.z;

        positions[21, 0] = LemonRed.transform.position.x;
        positions[21, 1] = LemonRed.transform.position.y;
        positions[21, 2] = LemonRed.transform.position.z;

        positions[22, 0] = LemonOrange.transform.position.x;
        positions[22, 1] = LemonOrange.transform.position.y;
        positions[22, 2] = LemonOrange.transform.position.z;

        positions[23, 0] = LemonYellow.transform.position.x;
        positions[23, 1] = LemonYellow.transform.position.y;
        positions[23, 2] = LemonYellow.transform.position.z;

        positions[24, 0] = LemonPurple.transform.position.x;
        positions[24, 1] = LemonPurple.transform.position.y;
        positions[24, 2] = LemonPurple.transform.position.z;
    }

}
