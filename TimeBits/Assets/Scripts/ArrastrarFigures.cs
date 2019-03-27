using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrastrarFigures : MonoBehaviour
{
    public AudioSource PutRight;
    public AudioSource PutWrong;

    private Image BaVerde, BaRoja, BaNaranja, BaMorado, BaAmarillo, ApVerde, ApRoja, ApNaranja, ApMorado, ApAmarillo, UvaVerde, UvaRoja, UvaNaranja, UvaMorado, UvaAmarillo, LeVerde, LeRoja, LeNaranja, LeMorado, LeAmarillo, StraVerde, StraRoja, StraNaranja, StraMorado, StraAmarillo;
    public Canvas canv;
    public GameObject pshexblue, pshexblueba, pshexgreen, pshexyellow, pshexred, pscircleblue, pscircledblue, pscirclered, pscircleyellow, pscirclegreen, pstrianglered, pstrianglegreen, pstriangleyellow, pstriangleblue, pstriangledblue, pssqudblue, pssqublue, pssquyellow, pssqured, pssqugreen, psstarred, psstarblue, psstardblue, psstaryellow, psstargreen;
    public GameObject BaYellow, BaOrange, BaPurple, BaGreen, BaRed, GreenBanana, OrangeBanana, YellowBanana, RedBanana, PurpleBanana, MaOrange, MaGreen, MaPurple, MaYellow, MaRed, GreenApple, YellowApple, PurpleApple, RedApple, OrangeApple;
    public GameObject GreenLemon, YellowLemon, PurpleLemon, RedLemon, OrangeLemon, LemonGreen, LemonYellow, LemonPurple, LemonRed, LemonOrange, UvaRed, UvaGreen, UvaOrange, YellowUva, PurpleUva, RedUva, GreenUva, OrangeUva, UvaYellow, UvaPurple;
    public GameObject GreenStra, YellowStra, PurpleStra, RedStra, OrangeStra, StraGreen, StraYellow, StraPurple, StraRed, StraOrange;
    public GameObject panelwin;
    Vector2 BaYellowInitialPos, BaOrangeInitialPos, BaRedInitialPos, BaGreenInitialPos, BaPurpleInitialPos, straYellowInitialPos, straOrangeInitialPos, straRedInitialPos, straGreenInitialPos, straPurpleInitialPos, uvaYellowInitialPos, uvaOrangeInitialPos, uvaRedInitialPos, uvaGreenInitialPos, uvaPurpleInitialPos;
    Vector2 LeYellowInitialPos, LeOrangeInitialPos, LeRedInitialPos, LeGreenInitialPos, LePurpleInitialPos, MaYellowInitialPos, MaOrangeInitialPos, MaRedInitialPos, MaGreenInitialPos, MaPurpleInitialPos;

    bool BaGreenPut = false;
    bool BaRedPut = false;
    bool BaPurplePut = false;
    bool BaYellowPut = false;
    bool BaOrangePut = false;
    bool MaGreenPut = false;
    bool MaRedPut = false;
    bool MaPurplePut = false;
    bool MaYellowPut = false;
    bool MaOrangePut = false;
    bool StraGreenPut = false;
    bool StraRedPut = false;
    bool StraPurplePut = false;
    bool StraYellowPut = false;
    bool StraOrangePut = false;
    bool LeGreenPut = false;
    bool LeRedPut = false;
    bool LePurplePut = false;
    bool LeYellowPut = false;
    bool LeOrangePut = false;
    bool UvaGreenPut = false;
    bool UvaRedPut = false;
    bool UvaPurplePut = false;
    bool UvaYellowPut = false;
    bool UvaOrangePut = false;

    void Start()
    {
        //event - event tigger -- drag y enddrag
        BaVerde = GameObject.Find("CircleGreen").GetComponent<Image>();
        BaRoja = GameObject.Find("CircleRed").GetComponent<Image>();
        BaNaranja = GameObject.Find("CircleBlueBa").GetComponent<Image>();
        BaMorado = GameObject.Find("CircleBlue").GetComponent<Image>();
        BaAmarillo = GameObject.Find("CircleYellow").GetComponent<Image>();

        //two     play area
        ApVerde = GameObject.Find("SquareGreen").GetComponent<Image>();
        ApRoja = GameObject.Find("SquareRed").GetComponent<Image>();
        ApNaranja = GameObject.Find("SquareBlueBa").GetComponent<Image>();
        ApMorado = GameObject.Find("SquareBlue").GetComponent<Image>();
        ApAmarillo = GameObject.Find("SquareYellow").GetComponent<Image>();

        //four
        UvaVerde = GameObject.Find("HexagoneGreen").GetComponent<Image>();
        UvaRoja = GameObject.Find("HexagoneRed").GetComponent<Image>();
        UvaNaranja = GameObject.Find("HexagoneBlueBa").GetComponent<Image>();
        UvaMorado = GameObject.Find("HexagoneBlue").GetComponent<Image>();
        UvaAmarillo = GameObject.Find("HexagoneYellow").GetComponent<Image>();
        //three
        StraVerde = GameObject.Find("StarGreen").GetComponent<Image>();
        StraRoja = GameObject.Find("StarRed").GetComponent<Image>();
        StraNaranja = GameObject.Find("StarBlueBa").GetComponent<Image>();
        StraMorado = GameObject.Find("StarBlue").GetComponent<Image>();
        StraAmarillo = GameObject.Find("StarYellow").GetComponent<Image>();
        //five
        LeVerde = GameObject.Find("TriangleGreen").GetComponent<Image>();
        LeRoja = GameObject.Find("TriangleRed").GetComponent<Image>();
        LeNaranja = GameObject.Find("TriangleBlueBa").GetComponent<Image>();
        LeMorado = GameObject.Find("TriangleBlue").GetComponent<Image>();
        LeAmarillo = GameObject.Find("TriangleYellow").GetComponent<Image>();

        BaYellowInitialPos = BaYellow.transform.position;
        BaOrangeInitialPos = BaOrange.transform.position;
        BaRedInitialPos = BaRed.transform.position;
        BaGreenInitialPos = BaGreen.transform.position;
        BaPurpleInitialPos = BaPurple.transform.position;

        MaYellowInitialPos = MaYellow.transform.position;
        MaOrangeInitialPos = MaOrange.transform.position;
        MaRedInitialPos = MaRed.transform.position;
        MaGreenInitialPos = MaGreen.transform.position;
        MaPurpleInitialPos = MaPurple.transform.position;

        straYellowInitialPos = StraYellow.transform.position;
        straOrangeInitialPos = StraOrange.transform.position;
        straRedInitialPos = StraRed.transform.position;
        straGreenInitialPos = StraGreen.transform.position;
        straPurpleInitialPos = StraPurple.transform.position;

        uvaYellowInitialPos = UvaYellow.transform.position;
        uvaOrangeInitialPos = UvaOrange.transform.position;
        uvaRedInitialPos = UvaRed.transform.position;
        uvaGreenInitialPos = UvaGreen.transform.position;
        uvaPurpleInitialPos = UvaPurple.transform.position;

        LeYellowInitialPos = LemonYellow.transform.position;
        LeOrangeInitialPos = LemonOrange.transform.position;
        LeRedInitialPos = LemonRed.transform.position;
        LeGreenInitialPos = LemonGreen.transform.position;
        LePurpleInitialPos = LemonPurple.transform.position;



    }


    void Update()
    {
        if (BaGreenPut&& BaRedPut&& BaYellowPut && BaPurplePut && BaOrangePut && MaOrangePut && MaGreenPut&& MaYellowPut&& MaRedPut&&MaPurplePut&&StraGreenPut&& StraYellowPut && StraPurplePut&& StraOrangePut &&StraRedPut && LeGreenPut &&LeRedPut && LeYellowPut && LeOrangePut && LePurplePut && UvaGreenPut&& UvaPurplePut && UvaYellowPut&& UvaRedPut&&UvaOrangePut )
        {
            panelwin.SetActive(true);
        }
    }


    public void DragBaYellow()
    {
        if (!BaYellowPut)
        {
            BaYellow.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragBaOrange()
    {
        if (!BaOrangePut)
        {
            BaOrange.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragBaPurple()
    {
        if (!BaPurplePut)
        {
            BaPurple.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragBaRed()
    {
        if (!BaRedPut)
        {
            BaRed.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragBaGreen()
    {
        if (!BaGreenPut)
        {
            BaGreen.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }


    }
    public void DragMaYellow()
    {
        if (!MaYellowPut)
        {
            MaYellow.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragMaOrange()
    {
        if (!MaOrangePut)
        {
            MaOrange.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragMaPurple()
    {
        if (!MaPurplePut)
        {
            MaPurple.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragMaRed()
    {
        if (!MaRedPut)
        {
            MaRed.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragMaGreen()
    {
        if (!MaGreenPut)
        {
            MaGreen.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }


    }
    public void DragUvaYellow()
    {
        if (!UvaYellowPut)
        {
            UvaYellow.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragUvaOrange()
    {
        if (!UvaOrangePut)
        {
            UvaOrange.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragUvaPurple()
    {
        if (!UvaPurplePut)
        {
            UvaPurple.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragUvaRed()
    {
        if (!UvaRedPut)
        {
            UvaRed.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragUvaGreen()
    {
        if (!UvaGreenPut)
        {
            UvaGreen.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }


    }
    public void DragLeYellow()
    {
        if (!LeYellowPut)
        {
            LemonYellow.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragLeOrange()
    {
        if (!LeOrangePut)
        {
            LemonOrange.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragLePurple()
    {
        if (!LePurplePut)
        {
            LemonPurple.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragLeRed()
    {
        if (!LeRedPut)
        {
            LemonRed.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragLeGreen()
    {
        if (!LeGreenPut)
        {
            LemonGreen.transform.position = Input.mousePosition;
        }


    }

    public void DragstraYellow()
    {
        if (!StraYellowPut)
        {
            StraYellow.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragstraOrange()
    {
        if (!StraOrangePut)
        {
            StraOrange.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragstraPurple()
    {
        if (!StraPurplePut)
        {
            StraPurple.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
    }
    public void DragstraRed()
    {
        if (!StraRedPut)
        {
            StraRed.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }
        }
    public void DragstraGreen()
    {
        if (!StraGreenPut)
        {
            StraGreen.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
        }


    }





    public void DropBaYellow()
    {
        float Distance = Vector3.Distance(BaYellow.transform.position, YellowBanana.transform.position);
        if (Distance < 50)
        {
            BaYellow.transform.position = YellowBanana.transform.position;
            BaAmarillo.sprite = Resources.Load<Sprite>("Figures/circle_yellow");
            BaAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaYellowPut = true;
            Destroy(BaYellow);
            GameObject circleyellow = Instantiate(pscircleyellow, YellowBanana.transform.position, YellowBanana.transform.rotation) as GameObject;
            circleyellow.transform.SetParent(canv.transform);


        }
        else
        {
            BaYellow.transform.position = BaYellowInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropBaOrange()
    {
        float Distance = Vector3.Distance(BaOrange.transform.position, OrangeBanana.transform.position);
        if (Distance < 50)
        {
            BaOrange.transform.position = OrangeBanana.transform.position;
            BaNaranja.sprite = Resources.Load<Sprite>("Figures/circle_blue");
            BaNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaOrangePut = true;
            Destroy(BaOrange);
            GameObject circledblue = Instantiate(pscircleblue, OrangeBanana.transform.position, OrangeBanana.transform.rotation) as GameObject;
            circledblue.transform.SetParent(canv.transform);

        }
        else
        {
            BaOrange.transform.position = BaOrangeInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropBaPurple()
    {
        float Distance = Vector3.Distance(BaPurple.transform.position, PurpleBanana.transform.position);
        if (Distance < 50)
        {
            BaPurple.transform.position = PurpleBanana.transform.position;
            BaMorado.sprite = Resources.Load<Sprite>("Figures/circle_dblue");
            BaMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaPurplePut = true;
            Destroy(BaPurple);
            GameObject circleblue = Instantiate(pscircleblue, PurpleBanana.transform.position, PurpleBanana.transform.rotation) as GameObject;
            circleblue.transform.SetParent(canv.transform);

        }
        else
        {
            BaPurple.transform.position = BaPurpleInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropBaRed()
    {
        float Distance = Vector3.Distance(BaRed.transform.position, RedBanana.transform.position);
        if (Distance < 50)
        {
            BaRed.transform.position = RedBanana.transform.position;
            BaRoja.sprite = Resources.Load<Sprite>("Figures/circle_red");
            BaRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaRedPut = true;
            Destroy(BaRed);
            GameObject circlered = Instantiate(pscirclered, RedBanana.transform.position, RedBanana.transform.rotation) as GameObject;
            circlered.transform.SetParent(canv.transform);
        }
        else
        {
            BaRed.transform.position = BaRedInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropBaGreen()
    {
        float Distance = Vector3.Distance(BaGreen.transform.position, GreenBanana.transform.position);
        if (Distance < 50)
        {
            BaGreen.transform.position = GreenBanana.transform.position;
            BaVerde.sprite = Resources.Load<Sprite>("Figures/circle_green");
            BaVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaGreenPut = true;
            Destroy(BaGreen);
            GameObject circlegreen = Instantiate(pscirclegreen, GreenBanana.transform.position, GreenBanana.transform.rotation) as GameObject;
            circlegreen.transform.SetParent(canv.transform);
        }
        else
        {

            BaGreen.transform.position = BaGreenInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }

    public void DropMaYellow()
    {
        float Distance = Vector3.Distance(MaYellow.transform.position, YellowApple.transform.position);
        if (Distance < 50)
        {
            MaYellow.transform.position = YellowApple.transform.position;
            ApAmarillo.sprite = Resources.Load<Sprite>("Figures/square_yellow");
            ApAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaYellowPut = true;
            Destroy(MaYellow);
            GameObject squayellow = Instantiate(pssquyellow, YellowApple.transform.position, YellowApple.transform.rotation) as GameObject;
            squayellow.transform.SetParent(canv.transform);

        }
        else
        {
            MaYellow.transform.position = MaYellowInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropMaOrange()
    {
        float Distance = Vector3.Distance(MaOrange.transform.position, OrangeApple.transform.position);
        if (Distance < 50)
        {
            MaOrange.transform.position = OrangeApple.transform.position;
            ApNaranja.sprite = Resources.Load<Sprite>("Figures/square_blue");
            ApNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaOrangePut = true;
            Destroy(MaOrange);
            GameObject squablueba = Instantiate(pssqublue, OrangeApple.transform.position, OrangeApple.transform.rotation) as GameObject;
            squablueba.transform.SetParent(canv.transform);
        }
        else
        {
            MaOrange.transform.position = MaOrangeInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropMaPurple()
    {
        float Distance = Vector3.Distance(MaPurple.transform.position, PurpleApple.transform.position);
        if (Distance < 50)
        {
            MaPurple.transform.position = PurpleApple.transform.position;
            ApMorado.sprite = Resources.Load<Sprite>("Figures/square_dblue");
            ApMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaPurplePut = true;
            Destroy(MaPurple);
            GameObject squablue = Instantiate(pssqudblue, MaPurple.transform.position, MaPurple.transform.rotation) as GameObject;
            squablue.transform.SetParent(canv.transform);
        }
        else
        {
            MaPurple.transform.position = BaPurpleInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropMaRed()
    {
        float Distance = Vector3.Distance(MaRed.transform.position, RedApple.transform.position);
        if (Distance < 50)
        {
            MaRed.transform.position = RedApple.transform.position;
            ApRoja.sprite = Resources.Load<Sprite>("Figures/square_red");
            ApRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaRedPut = true;
            Destroy(MaRed);
            GameObject squared = Instantiate(pssqured, RedApple.transform.position, RedApple.transform.rotation) as GameObject;
            squared.transform.SetParent(canv.transform);
        }
        else
        {
            MaRed.transform.position = MaRedInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropMaGreen()
    {
        float Distance = Vector3.Distance(MaGreen.transform.position, GreenApple.transform.position);
        if (Distance < 50)
        {
            MaGreen.transform.position = GreenApple.transform.position;
            ApVerde.sprite = Resources.Load<Sprite>("Figures/square_green");
            ApVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaGreenPut = true;
            Destroy(MaGreen);
            GameObject squagreen = Instantiate(pssqugreen, GreenApple.transform.position, GreenApple.transform.rotation) as GameObject;
            squagreen.transform.SetParent(canv.transform);
        }
        else
        {

            MaGreen.transform.position = MaGreenInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropUvaYellow()
    {
        float Distance = Vector3.Distance(UvaYellow.transform.position, YellowUva.transform.position);
        if (Distance < 50)
        {
            UvaYellow.transform.position = YellowUva.transform.position;
            UvaAmarillo.sprite = Resources.Load<Sprite>("Figures/hexagon_yellow");
            UvaAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaYellowPut = true;
            Destroy(UvaYellow);

            GameObject hexagoneyellow = Instantiate(pshexyellow, YellowUva.transform.position, YellowUva.transform.rotation) as GameObject;
            hexagoneyellow.transform.SetParent(canv.transform);
        }
        else
        {
            UvaYellow.transform.position = uvaYellowInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropUvaOrange()
    {
        float Distance = Vector3.Distance(UvaOrange.transform.position, OrangeUva.transform.position);
        if (Distance < 50)
        {
            UvaOrange.transform.position = OrangeUva.transform.position;
            UvaNaranja.sprite = Resources.Load<Sprite>("Figures/hexagon_blue");
            UvaNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaOrangePut = true;
            Destroy(UvaOrange);

            GameObject hexagoneblue = Instantiate(pshexblue, UvaOrange.transform.position, UvaOrange.transform.rotation ) as GameObject;
            hexagoneblue.transform.SetParent(canv.transform);
        }
        else
        {
            UvaOrange.transform.position = uvaOrangeInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropUvaPurple()
    {
        float Distance = Vector3.Distance(UvaPurple.transform.position, PurpleUva.transform.position);
        if (Distance < 50)
        {
            UvaPurple.transform.position = PurpleUva.transform.position;
            UvaMorado.sprite = Resources.Load<Sprite>("Figures/hexagon_dblue");
            UvaMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaPurplePut = true;
            Destroy(UvaPurple);
            GameObject hexagoneblueba = Instantiate(pshexblueba, PurpleUva.transform.position, PurpleUva.transform.rotation) as GameObject;
            hexagoneblueba.transform.SetParent(canv.transform);
        }
        else
        {
            UvaPurple.transform.position = uvaPurpleInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropUvaRed()
    {
        float Distance = Vector3.Distance(UvaRed.transform.position, RedUva.transform.position);
        if (Distance < 50)
        {
            UvaRed.transform.position = RedUva.transform.position;
            UvaRoja.sprite = Resources.Load<Sprite>("Figures/hexagon_red");
            UvaRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaRedPut = true;
            Destroy(UvaRed);
            GameObject hexagonered = Instantiate(pshexred, RedUva.transform.position, RedUva.transform.rotation) as GameObject;
            hexagonered.transform.SetParent(canv.transform);
        }
        else
        {
            UvaRed.transform.position = uvaRedInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropUvaGreen()
    {
        float Distance = Vector3.Distance(UvaGreen.transform.position, GreenUva.transform.position);
        if (Distance < 50)
        {
            UvaGreen.transform.position = GreenUva.transform.position;
            UvaVerde.sprite = Resources.Load<Sprite>("Figures/hexagon_green");
            UvaVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaGreenPut = true;
            Destroy(UvaGreen);
            GameObject hexagonegreen = Instantiate(pshexgreen, GreenUva.transform.position, GreenUva.transform.rotation) as GameObject;
            hexagonegreen.transform.SetParent(canv.transform);
        }
        else
        {

            UvaGreen.transform.position = uvaGreenInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropleYellow()
    {
        float Distance = Vector3.Distance(LemonYellow.transform.position, YellowLemon.transform.position);
        if (Distance < 50)
        {
            LemonYellow.transform.position = YellowLemon.transform.position;
            LeAmarillo.sprite = Resources.Load<Sprite>("Figures/triangle_yellow");
            LeAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeYellowPut = true;
            Destroy(LemonYellow);
            GameObject triangleyellow = Instantiate(pstriangleyellow, YellowLemon.transform.position, YellowLemon.transform.rotation) as GameObject;
            triangleyellow.transform.SetParent(canv.transform);
        }
        else
        {
            LemonYellow.transform.position = LeYellowInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropleOrange()
    {
        float Distance = Vector3.Distance(LemonOrange.transform.position, OrangeLemon.transform.position);
        if (Distance < 50)
        {
            LemonOrange.transform.position = OrangeLemon.transform.position;
            LeNaranja.sprite = Resources.Load<Sprite>("Figures/triangle_blue");
            LeNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeOrangePut = true;
            Destroy(LemonOrange);
            GameObject triangleblue = Instantiate(pstriangleblue, OrangeLemon.transform.position, OrangeLemon.transform.rotation) as GameObject;
            triangleblue.transform.SetParent(canv.transform);
        }
        else
        {
            LemonOrange.transform.position = LeOrangeInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DroplePurple()
    {
        float Distance = Vector3.Distance(LemonPurple.transform.position, PurpleLemon.transform.position);
        if (Distance < 50)
        {
            LemonPurple.transform.position = PurpleLemon.transform.position;
            LeMorado.sprite = Resources.Load<Sprite>("Figures/triangle_dblue");
            LeMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LePurplePut = true;
            Destroy(LemonPurple);
            GameObject triangledblue = Instantiate(pstriangledblue, PurpleLemon.transform.position, PurpleLemon.transform.rotation) as GameObject;
            triangledblue.transform.SetParent(canv.transform);
        }
        else
        {
            LemonPurple.transform.position = LePurpleInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropLeRed()
    {
        float Distance = Vector3.Distance(LemonRed.transform.position, RedLemon.transform.position);
        if (Distance < 50)
        {
            LemonRed.transform.position = RedLemon.transform.position;
            LeRoja.sprite = Resources.Load<Sprite>("Figures/triangle_red");
            LeRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeRedPut = true;
            Destroy(LemonRed);
            GameObject trianglered = Instantiate(pstrianglered, RedLemon.transform.position, RedLemon.transform.rotation) as GameObject;
            trianglered.transform.SetParent(canv.transform);
        }
        else
        {
            LemonRed.transform.position = LeRedInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropLeGreen()
    {
        float Distance = Vector3.Distance(LemonGreen.transform.position, GreenLemon.transform.position);
        if (Distance < 50)
        {
            LemonGreen.transform.position = GreenLemon.transform.position;
            LeVerde.sprite = Resources.Load<Sprite>("Figures/triangle_green");
            LeVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeGreenPut = true;
            Destroy(LemonGreen);
            GameObject trianglegreen = Instantiate(pstrianglegreen, GreenLemon.transform.position, GreenLemon.transform.rotation) as GameObject;
            trianglegreen.transform.SetParent(canv.transform);
        }
        else
        {

            LemonGreen.transform.position = LeGreenInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }

    public void DropStraYellow()
    {
        float Distance = Vector3.Distance(StraYellow.transform.position, YellowStra.transform.position);
        if (Distance < 50)
        {
            StraYellow.transform.position = YellowStra.transform.position;
            StraAmarillo.sprite = Resources.Load<Sprite>("Figures/star_yellow");
            StraAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraYellowPut = true;
            Destroy(StraYellow);
            GameObject staryellow = Instantiate(psstaryellow, YellowStra.transform.position, YellowStra.transform.rotation) as GameObject;
            staryellow.transform.SetParent(canv.transform);
        }
        else
        {
            StraYellow.transform.position = straYellowInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropStraOrange()
    {
        float Distance = Vector3.Distance(StraOrange.transform.position, OrangeStra.transform.position);
        if (Distance < 50)
        {
            StraOrange.transform.position = OrangeStra.transform.position;
            StraNaranja.sprite = Resources.Load<Sprite>("Figures/star_blue");
            StraNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraOrangePut = true;
            Destroy(StraOrange);
            GameObject starblue= Instantiate(psstarblue, OrangeStra.transform.position, OrangeStra.transform.rotation) as GameObject;
            starblue.transform.SetParent(canv.transform);
        }
        else
        {
            StraOrange.transform.position = straOrangeInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropStraPurple()
    {
        float Distance = Vector3.Distance(StraPurple.transform.position, PurpleStra.transform.position);
        if (Distance < 50)
        {
            StraPurple.transform.position = PurpleStra.transform.position;
            StraMorado.sprite = Resources.Load<Sprite>("Figures/star_dblue");
            StraMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraPurplePut = true;
            Destroy(StraPurple);
            GameObject stardblue = Instantiate(psstardblue, PurpleStra.transform.position, PurpleStra.transform.rotation) as GameObject;
            stardblue.transform.SetParent(canv.transform);
        }
        else
        {
            StraPurple.transform.position = straPurpleInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropStraRed()
    {
        float Distance = Vector3.Distance(StraRed.transform.position, RedStra.transform.position);
        if (Distance < 50)
        {
            StraRed.transform.position = RedStra.transform.position;
            StraRoja.sprite = Resources.Load<Sprite>("Figures/star_red");
            StraRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraRedPut = true;
            Destroy(StraRed);
            GameObject starred = Instantiate(psstarred, RedStra.transform.position, RedStra.transform.rotation) as GameObject;
            starred.transform.SetParent(canv.transform);
        }
        else
        {
            StraRed.transform.position = straRedInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
    public void DropStraGreen()
    {
        float Distance = Vector3.Distance(StraGreen.transform.position, GreenStra.transform.position);
        if (Distance < 50)
        {
            StraGreen.transform.position = GreenStra.transform.position;
            StraVerde.sprite = Resources.Load<Sprite>("Figures/star_green");
            StraVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraGreenPut = true;
            Destroy(StraGreen);
            GameObject stargreen = Instantiate(psstargreen, StraGreen.transform.position, StraGreen.transform.rotation) as GameObject;
            stargreen.transform.SetParent(canv.transform);
        }
        else
        {

            StraGreen.transform.position = straGreenInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
}
