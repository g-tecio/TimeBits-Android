using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrastrarHallowin : MonoBehaviour
{
    public AudioSource PutRight;
    public AudioSource PutWrong;
    public GameObject pan;
    private Image BaVerde, BaRoja, BaNaranja, BaMorado, BaAmarillo, ApVerde, ApRoja, ApNaranja, ApMorado, ApAmarillo, UvaVerde, UvaRoja, UvaNaranja, UvaMorado, UvaAmarillo, LeVerde, LeRoja, LeNaranja, LeMorado, LeAmarillo, StraVerde, StraRoja, StraNaranja, StraMorado, StraAmarillo;
    public Canvas canv;
    public GameObject
    psbananagreen, psbananaorange, psbananapurple, psbananared, psbananayellow,
    psgrapesgreen, psgrapesorange, psgrapespurple, psgrapesred, psgrapesyellow,
    pslemongreen, pslemonorange, pslemonpurple, pslemonred, pslemonyellow,
    psapplegreen, psappleorange, psapplepurple, psapplered, psappleyellow,
    psstrawberrygreen, psstrawberryorange, psstrawberrypurple, psstrawberryred, psstrawberryyellow;

    public GameObject BaYellow, BaOrange, BaPurple, BaGreen, BaRed, GreenBanana, OrangeBanana, YellowBanana, RedBanana, PurpleBanana, MaOrange, MaGreen, MaPurple, MaYellow, MaRed, GreenApple, YellowApple, PurpleApple, RedApple, OrangeApple;
    public GameObject GreenLemon, YellowLemon, RedLemon, PurpleLemon, OrangeLemon, LemonGreen, LemonYellow, LemonPurple, LemonRed, LemonOrange, UvaRed, UvaGreen, UvaOrange, YellowUva, PurpleUva, RedUva, GreenUva, OrangeUva, UvaYellow, UvaPurple;
    public GameObject GreenStra, YellowStra, PurpleStra, RedStra, OrangeStra, StraGreen, StraYellow, StraPurple, StraRed, StraOrange;

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

        BaVerde = GameObject.Find("GreenBanana").GetComponent<Image>();
        BaRoja = GameObject.Find("RedBanana").GetComponent<Image>();
        BaNaranja = GameObject.Find("OrangeBanana").GetComponent<Image>();
        BaMorado = GameObject.Find("PurpleBanana").GetComponent<Image>();
        BaAmarillo = GameObject.Find("YellowBanana").GetComponent<Image>();

        ApVerde = GameObject.Find("GreenApple").GetComponent<Image>();
        ApRoja = GameObject.Find("RedApple").GetComponent<Image>();
        ApNaranja = GameObject.Find("OrangeApple").GetComponent<Image>();
        ApMorado = GameObject.Find("PurpleApple").GetComponent<Image>();
        ApAmarillo = GameObject.Find("YellowApple").GetComponent<Image>();

        UvaVerde = GameObject.Find("GreenUva").GetComponent<Image>();
        UvaRoja = GameObject.Find("RedUva").GetComponent<Image>();
        UvaNaranja = GameObject.Find("OrangeUva").GetComponent<Image>();
        UvaMorado = GameObject.Find("PurpleUva").GetComponent<Image>();
        UvaAmarillo = GameObject.Find("YellowUva").GetComponent<Image>();

        LeVerde = GameObject.Find("GreenLemon").GetComponent<Image>();
        LeRoja = GameObject.Find("RedLemon").GetComponent<Image>();
        LeNaranja = GameObject.Find("OrangeLemon").GetComponent<Image>();
        LeMorado = GameObject.Find("PurpleLemon").GetComponent<Image>();
        LeAmarillo = GameObject.Find("YellowLemon").GetComponent<Image>();

        StraVerde = GameObject.Find("GreenStra").GetComponent<Image>();
        StraRoja = GameObject.Find("RedStra").GetComponent<Image>();
        StraNaranja = GameObject.Find("OrangeStra").GetComponent<Image>();
        StraMorado = GameObject.Find("PurpleStra").GetComponent<Image>();
        StraAmarillo = GameObject.Find("YellowStra").GetComponent<Image>();

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
        if (BaGreenPut && BaRedPut && BaYellowPut && BaPurplePut && BaOrangePut && MaOrangePut && MaGreenPut && MaYellowPut && MaRedPut && MaPurplePut && StraGreenPut && StraYellowPut && StraPurplePut && StraOrangePut && StraRedPut && LeGreenPut && LeRedPut && LeYellowPut && LeOrangePut && LePurplePut && UvaGreenPut && UvaPurplePut && UvaYellowPut && UvaRedPut && UvaOrangePut)
        {
            pan.SetActive(true);
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
            LemonGreen.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 100, Input.mousePosition.z);
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
            BaAmarillo.sprite = Resources.Load<Sprite>("completos/BananaYellow");
            BaAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaYellowPut = true;
            Destroy(BaYellow);

            GameObject bananayellow = Instantiate(psbananayellow, YellowBanana.transform.position, YellowBanana.transform.rotation) as GameObject;
            bananayellow.transform.SetParent(canv.transform);
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
            BaNaranja.sprite = Resources.Load<Sprite>("completos/BananaOrange");
            BaNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaOrangePut = true;
            Destroy(BaOrange);

            GameObject bananaorange = Instantiate(psbananaorange, OrangeBanana.transform.position, OrangeBanana.transform.rotation) as GameObject;
            bananaorange.transform.SetParent(canv.transform);
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
            BaMorado.sprite = Resources.Load<Sprite>("completos/BananaPurple");
            BaMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaPurplePut = true;
            Destroy(BaPurple);

            GameObject bananapurple = Instantiate(psbananapurple, PurpleBanana.transform.position, PurpleBanana.transform.rotation) as GameObject;
            bananapurple.transform.SetParent(canv.transform);
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
            BaRoja.sprite = Resources.Load<Sprite>("completos/BananaRed");
            BaRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaRedPut = true;
            Destroy(BaRed);

            GameObject bananared = Instantiate(psbananared, RedBanana.transform.position, RedBanana.transform.rotation) as GameObject;
            bananared.transform.SetParent(canv.transform);
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
            BaVerde.sprite = Resources.Load<Sprite>("completos/BananaGreen");
            BaVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            BaGreenPut = true;
            Destroy(BaGreen);

            GameObject bananagreen = Instantiate(psbananagreen, GreenBanana.transform.position, GreenBanana.transform.rotation) as GameObject;
            bananagreen.transform.SetParent(canv.transform);
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
            ApAmarillo.sprite = Resources.Load<Sprite>("completos/MaYellow");
            ApAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaYellowPut = true;
            Destroy(MaYellow);

            GameObject appleyellow = Instantiate(psappleyellow, YellowApple.transform.position, YellowApple.transform.rotation) as GameObject;
            appleyellow.transform.SetParent(canv.transform);
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
            ApNaranja.sprite = Resources.Load<Sprite>("completos/MaOrange");
            ApNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaOrangePut = true;
            Destroy(MaOrange);

            GameObject appleorange = Instantiate(psappleorange, OrangeApple.transform.position, OrangeApple.transform.rotation) as GameObject;
            appleorange.transform.SetParent(canv.transform);
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
            ApMorado.sprite = Resources.Load<Sprite>("completos/MaPurple");
            ApMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaPurplePut = true;
            Destroy(MaPurple);

            GameObject applepurple = Instantiate(psapplepurple, PurpleApple.transform.position, PurpleApple.transform.rotation) as GameObject;
            applepurple.transform.SetParent(canv.transform);
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
            ApRoja.sprite = Resources.Load<Sprite>("completos/MaRed");
            ApRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaRedPut = true;
            Destroy(MaRed);

            GameObject applered = Instantiate(psapplered, RedApple.transform.position, RedApple.transform.rotation) as GameObject;
            applered.transform.SetParent(canv.transform);
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
            ApVerde.sprite = Resources.Load<Sprite>("completos/MaVerde");
            ApVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            MaGreenPut = true;
            Destroy(MaGreen);

            GameObject applegreen = Instantiate(psapplegreen, GreenApple.transform.position, GreenApple.transform.rotation) as GameObject;
            applegreen.transform.SetParent(canv.transform);
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
            UvaAmarillo.sprite = Resources.Load<Sprite>("completos/UvaYellow");
            UvaAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaYellowPut = true;
            Destroy(UvaYellow);

            GameObject grapesyellow = Instantiate(psgrapesyellow, YellowUva.transform.position, YellowUva.transform.rotation) as GameObject;
            grapesyellow.transform.SetParent(canv.transform);
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
            UvaNaranja.sprite = Resources.Load<Sprite>("completos/UvaOrange");
            UvaNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaOrangePut = true;
            Destroy(UvaOrange);

            GameObject grapesorange = Instantiate(psgrapesorange, OrangeUva.transform.position, OrangeUva.transform.rotation) as GameObject;
            grapesorange.transform.SetParent(canv.transform);
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
            UvaMorado.sprite = Resources.Load<Sprite>("completos/UvaPurple");
            UvaMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaPurplePut = true;
            Destroy(UvaPurple);

            GameObject grapespurple = Instantiate(psgrapespurple, PurpleUva.transform.position, PurpleUva.transform.rotation) as GameObject;
            grapespurple.transform.SetParent(canv.transform);
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
            UvaRoja.sprite = Resources.Load<Sprite>("completos/UvaRed");
            UvaRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaRedPut = true;
            Destroy(UvaRed);

            GameObject grapesred = Instantiate(psgrapesred, RedUva.transform.position, RedUva.transform.rotation) as GameObject;
            grapesred.transform.SetParent(canv.transform);
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
            UvaVerde.sprite = Resources.Load<Sprite>("completos/UvaGreen");
            UvaVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            UvaGreenPut = true;
            Destroy(UvaGreen);

            GameObject grapesgreen = Instantiate(psgrapesgreen, GreenUva.transform.position, GreenUva.transform.rotation) as GameObject;
            grapesgreen.transform.SetParent(canv.transform);
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
            LeAmarillo.sprite = Resources.Load<Sprite>("completos/LeYellow");
            LeAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeYellowPut = true;
            Destroy(LemonYellow);

            GameObject lemonyellow = Instantiate(pslemonyellow, YellowLemon.transform.position, YellowLemon.transform.rotation) as GameObject;
            lemonyellow.transform.SetParent(canv.transform);
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
            LeNaranja.sprite = Resources.Load<Sprite>("completos/LeOrange");
            LeNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeOrangePut = true;
            Destroy(LemonOrange);

            GameObject lemonorange = Instantiate(pslemonorange, OrangeLemon.transform.position, OrangeLemon.transform.rotation) as GameObject;
            lemonorange.transform.SetParent(canv.transform);
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
            LeMorado.sprite = Resources.Load<Sprite>("completos/LePurple");
            LeMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LePurplePut = true;
            Destroy(LemonPurple);

            GameObject lemonpurple = Instantiate(pslemonpurple, PurpleLemon.transform.position, PurpleLemon.transform.rotation) as GameObject;
            lemonpurple.transform.SetParent(canv.transform);
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
            LeRoja.sprite = Resources.Load<Sprite>("completos/LeRed");
            LeRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeRedPut = true;
            Destroy(LemonRed);

            GameObject lemonred = Instantiate(pslemonred, RedLemon.transform.position, RedLemon.transform.rotation) as GameObject;
            lemonred.transform.SetParent(canv.transform);

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
            LeVerde.sprite = Resources.Load<Sprite>("completos/LeGreen");
            LeVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            LeGreenPut = true;
            Destroy(LemonGreen);

            GameObject lemongreen = Instantiate(pslemongreen, GreenLemon.transform.position, GreenLemon.transform.rotation) as GameObject;
            lemongreen.transform.SetParent(canv.transform);
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
            StraAmarillo.sprite = Resources.Load<Sprite>("completos/StraYellow");
            StraAmarillo.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraYellowPut = true;
            Destroy(StraYellow);

            GameObject strayellow = Instantiate(psstrawberryyellow, YellowStra.transform.position, YellowStra.transform.rotation) as GameObject;
            strayellow.transform.SetParent(canv.transform);
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
            StraNaranja.sprite = Resources.Load<Sprite>("completos/StraOrange");
            StraNaranja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraOrangePut = true;
            Destroy(StraOrange);

            GameObject straorange = Instantiate(psstrawberryorange, OrangeStra.transform.position, OrangeStra.transform.rotation) as GameObject;
            straorange.transform.SetParent(canv.transform);
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
            StraMorado.sprite = Resources.Load<Sprite>("completos/StraPurple");
            StraMorado.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraPurplePut = true;
            Destroy(StraPurple);

            GameObject strapurple = Instantiate(psstrawberrypurple, PurpleStra.transform.position, PurpleStra.transform.rotation) as GameObject;
            strapurple.transform.SetParent(canv.transform);
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
            StraRoja.sprite = Resources.Load<Sprite>("completos/StraRed");
            StraRoja.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraRedPut = true;
            Destroy(StraRed);

            GameObject strared = Instantiate(psstrawberryred, RedStra.transform.position, RedStra.transform.rotation) as GameObject;
            strared.transform.SetParent(canv.transform);
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
            StraVerde.sprite = Resources.Load<Sprite>("completos/StraGreen");
            StraVerde.transform.localScale = new Vector3(0.06318879f, 0.1931521f, 0.05946097f);
            PutRight.Play();
            StraGreenPut = true;
            Destroy(StraGreen);

            GameObject stragreen = Instantiate(psstrawberrygreen, GreenStra.transform.position, GreenStra.transform.rotation) as GameObject;
            stragreen.transform.SetParent(canv.transform);
        }
        else
        {

            StraGreen.transform.position = straGreenInitialPos;
            PutWrong.Play();
            Handheld.Vibrate();
        }
    }
}
