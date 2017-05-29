using UnityEngine;
using UnityEngine.UI;
using Functions;

public class Menu : MonoBehaviour
{
    Sprite LockedSkinTexture;
    Sprite Skin1Texture;
    Sprite Skin2Texture;
    Sprite Skin3Texture;
    Sprite Skin4Texture;
    Sprite Skin5Texture;
    Sprite Skin6Texture;
    Sprite Skin7Texture;
    Sprite Skin8Texture;
    Sprite Skin9Texture;
    Sprite Skin10Texture;
    Sprite Skin11Texture;
    Sprite Skin12Texture;
    Sprite Skin13Texture;
    Sprite Skin14Texture;
    Sprite Skin15Texture;
    Sprite MusicONTexture;
    Sprite MusicOFFTexture;
    private bool MusicStatus;
    private string PlayerPos;

    /*------------------------------------------------------------> LOAD FUNCTIONS <------------------------------------------------------------*/

    public void LoadData()
    {
        if (!PlayerPrefs.HasKey("First Start")) PlayerPrefs.SetInt("First Start", 1); PlayerPrefs.SetString("Current skin", "Skin 1");
        BallBehavior.Coins = PlayerPrefs.GetInt("Coins");
        BallBehavior.HighestScore = PlayerPrefs.GetInt("Highest Score");
        BallBehavior.Skinid = PlayerPrefs.GetString("Current skin");
    }

    private void LoadTextures()
    {
        LockedSkinTexture = Resources.Load<Sprite>("locked");
        Skin1Texture = Resources.Load<Sprite>("Skin 1");
        Skin2Texture = Resources.Load<Sprite>("Skin 2");
        Skin3Texture = Resources.Load<Sprite>("Skin 3");
        Skin4Texture = Resources.Load<Sprite>("Skin 4");
        Skin5Texture = Resources.Load<Sprite>("Skin 5");
        Skin6Texture = Resources.Load<Sprite>("Skin 6");
        Skin7Texture = Resources.Load<Sprite>("Skin 7");
        Skin8Texture = Resources.Load<Sprite>("Skin 8");
        Skin9Texture = Resources.Load<Sprite>("Skin 9");
        Skin10Texture = Resources.Load<Sprite>("Skin 10");
        Skin11Texture = Resources.Load<Sprite>("Skin 11");
        Skin12Texture = Resources.Load<Sprite>("Skin 12");
        Skin13Texture = Resources.Load<Sprite>("Skin 13");
        Skin14Texture = Resources.Load<Sprite>("Skin 14");
        Skin15Texture = Resources.Load<Sprite>("Skin 15");
        MusicONTexture = Resources.Load<Sprite>("MusicON");
        MusicOFFTexture = Resources.Load<Sprite>("MusicOFF");
    }

    private void LoadMainMenu()
    {
        GameObject.Find("Play button").GetComponent<Image>().enabled = true;
        GameObject.Find("Play button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
        GameObject.Find("Skins button").GetComponent<Image>().enabled = true;
        GameObject.Find("Skins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
        GameObject.Find("Quit button").GetComponent<Image>().enabled = true;
        GameObject.Find("Quit button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
    }

    public void LoadSkinsMenu()
    {
        GameObject.Find("House icon").GetComponent<Image>().enabled = true;
        GameObject.Find("Current skin").GetComponent<Image>().enabled = true;
        GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        if (BallBehavior.Skinid == "Skin 1") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin1Texture;
        else if (BallBehavior.Skinid == "Skin 2") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin2Texture;
        else if (BallBehavior.Skinid == "Skin 3") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin3Texture;
        else if (BallBehavior.Skinid == "Skin 4") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin4Texture;
        else if (BallBehavior.Skinid == "Skin 5") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin5Texture;
        else if (BallBehavior.Skinid == "Skin 6") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin6Texture;
        else if (BallBehavior.Skinid == "Skin 7") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin7Texture;
        else if (BallBehavior.Skinid == "Skin 8") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin8Texture;
        else if (BallBehavior.Skinid == "Skin 9") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin9Texture;
        else if (BallBehavior.Skinid == "Skin 10") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin10Texture;
        else if (BallBehavior.Skinid == "Skin 11") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin11Texture;
        else if (BallBehavior.Skinid == "Skin 12") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin12Texture;
        else if (BallBehavior.Skinid == "Skin 13") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin13Texture;
        else if (BallBehavior.Skinid == "Skin 14") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin14Texture;
        else if (BallBehavior.Skinid == "Skin 15") GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin15Texture;
        GameObject.Find("Browse skins button").GetComponent<Image>().enabled = true;
        GameObject.Find("Browse skins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
        GameObject.Find("Buy random skin button").transform.GetChild(1).gameObject.GetComponent<Text>().enabled = true;
        GameObject.Find("Buy random skin button").transform.GetChild(2).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Buy random skin button").GetComponent<Image>().enabled = true;
        GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
        GameObject.Find("Buy coins button").GetComponent<Image>().enabled = true;
        GameObject.Find("Buy coins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
        PlayerPos = "Skins menu";
    }

    public void LoadBrowseSkins()
    {
        GameObject.Find("Current skin").GetComponent<Image>().enabled = false;
        GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Browse skins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Browse skins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(1).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(2).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Buy coins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy coins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Skin 1").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 1").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 2").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 2").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 3").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 3").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 4").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 4").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 5").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 5").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 6").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 6").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 7").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 7").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 8").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 8").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 9").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 9").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 10").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 10").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 11").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 11").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 12").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 12").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 13").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 13").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 14").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 14").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 15").GetComponent<Image>().enabled = true;
        GameObject.Find("Skin 15").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;

        if ((PlayerPrefs.GetInt("Skin 2") == 0)) GameObject.Find("Skin 2").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 2") == 1)) GameObject.Find("Skin 2").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin2Texture;
        if ((PlayerPrefs.GetInt("Skin 3") == 0)) GameObject.Find("Skin 3").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 3") == 1)) GameObject.Find("Skin 3").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin3Texture;
        if ((PlayerPrefs.GetInt("Skin 4") == 0)) GameObject.Find("Skin 4").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 4") == 1)) GameObject.Find("Skin 4").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin4Texture;
        if ((PlayerPrefs.GetInt("Skin 5") == 0)) GameObject.Find("Skin 5").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 5") == 1)) GameObject.Find("Skin 5").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin5Texture;
        if ((PlayerPrefs.GetInt("Skin 6") == 0)) GameObject.Find("Skin 6").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 6") == 1)) GameObject.Find("Skin 6").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin6Texture;
        if ((PlayerPrefs.GetInt("Skin 7") == 0)) GameObject.Find("Skin 7").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 7") == 1)) GameObject.Find("Skin 7").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin7Texture;
        if ((PlayerPrefs.GetInt("Skin 8") == 0)) GameObject.Find("Skin 8").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 8") == 1)) GameObject.Find("Skin 8").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin8Texture;
        if ((PlayerPrefs.GetInt("Skin 9") == 0)) GameObject.Find("Skin 9").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 9") == 1)) GameObject.Find("Skin 9").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin9Texture;
        if ((PlayerPrefs.GetInt("Skin 10") == 0)) GameObject.Find("Skin 10").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 10") == 1)) GameObject.Find("Skin 10").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin10Texture;
        if ((PlayerPrefs.GetInt("Skin 11") == 0)) GameObject.Find("Skin 11").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 11") == 1)) GameObject.Find("Skin 11").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin11Texture;
        if ((PlayerPrefs.GetInt("Skin 12") == 0)) GameObject.Find("Skin 12").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 12") == 1)) GameObject.Find("Skin 12").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin12Texture;
        if ((PlayerPrefs.GetInt("Skin 13") == 0)) GameObject.Find("Skin 13").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 13") == 1)) GameObject.Find("Skin 13").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin13Texture;
        if ((PlayerPrefs.GetInt("Skin 14") == 0)) GameObject.Find("Skin 14").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 14") == 1)) GameObject.Find("Skin 14").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin14Texture;
        if ((PlayerPrefs.GetInt("Skin 15") == 0)) GameObject.Find("Skin 15").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = LockedSkinTexture;
        if ((PlayerPrefs.GetInt("Skin 15") == 1)) GameObject.Find("Skin 15").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin15Texture;
        PlayerPos = "Browse skins";
    }

    public void LoadBuyRandomSkin()
    {
        if ((PlayerPrefs.GetInt("Coins") < 100))
        {
            GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().text = "Not enough coins";
            Invoke("NotEnoughCoins", 2);
        }
        else if (PlayerPrefs.GetInt("Skin 2") == 1 && PlayerPrefs.GetInt("Skin 3") == 1 && PlayerPrefs.GetInt("Skin 4") == 1 && PlayerPrefs.GetInt("Skin 5") == 1 && PlayerPrefs.GetInt("Skin 6") == 1 && PlayerPrefs.GetInt("Skin 7") == 1 && PlayerPrefs.GetInt("Skin 8") == 1 && PlayerPrefs.GetInt("Skin 9") == 1 && PlayerPrefs.GetInt("Skin 10") == 1 && PlayerPrefs.GetInt("Skin 11") == 1 && PlayerPrefs.GetInt("Skin 12") == 1 && PlayerPrefs.GetInt("Skin 13") == 1 && PlayerPrefs.GetInt("Skin 14") == 1 && PlayerPrefs.GetInt("Skin 15") == 1)
        {
            GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().text = "No more skins";
            GameObject.Find("Buy random skin button").transform.GetChild(1).gameObject.GetComponent<Text>().text = "lul";
            GameObject.Find("Buy random skin button").transform.GetChild(2).gameObject.GetComponent<Image>().enabled = false;
            Invoke("HaveAllSkins", 2);
        }
        else
        {
            DisableSkinsMenu();
            GameObject.Find("Random skin").GetComponent<Image>().enabled = true;
            GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
            GameObject.Find("Random skin").transform.GetChild(1).gameObject.GetComponent<Text>().enabled = true;
            GameObject.Find("Yaaaay button").GetComponent<Image>().enabled = true;
            GameObject.Find("Yaaaay button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;
            int RandomSkin = Random.Range(2, 10);
            while ((PlayerPrefs.GetInt("Skin " + RandomSkin) == 1))
            {
                RandomSkin = Random.Range(2, 10);
            }
            BallBehavior.Skinid = "Skin " + RandomSkin;
            PlayerPrefs.SetString("Current skin", "Skin " + RandomSkin);
            PlayerPrefs.SetInt("Skin " + RandomSkin, 1);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 100);
            BallBehavior.Coins -= 100;
            GameObject.Find("Coins").GetComponent<Text>().text = "Coins:" + BallBehavior.Coins;
            Debugger_Function();
        }
        PlayerPos = "Buy random skin";
    }
    /*------------------------------------------------------------> DISABLE FUNCTIONS <------------------------------------------------------------*/
    private void DisableMainMenu()
    {
        GameObject.Find("Play button").GetComponent<Image>().enabled = false;
        GameObject.Find("Play button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Skins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Skins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Quit button").GetComponent<Image>().enabled = false;
        GameObject.Find("Quit button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
    }

    private void DisableSkinsMenu()
    {
        GameObject.Find("House icon").GetComponent<Image>().enabled = false;
        GameObject.Find("Current skin").GetComponent<Image>().enabled = false;
        GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Browse skins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Browse skins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(1).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(2).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Buy random skin button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy coins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy coins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
    }

    private void DisableBrowseSkins()
    {
        GameObject.Find("Skin 1").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 1").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 2").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 2").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 3").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 3").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 4").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 4").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 5").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 5").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 6").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 6").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 7").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 7").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 8").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 8").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 9").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 9").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 10").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 10").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 11").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 11").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 12").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 12").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 13").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 13").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 14").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 14").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 15").GetComponent<Image>().enabled = false;
        GameObject.Find("Skin 15").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
    }

    private void DisableBuyRandomSkin()
    {
        GameObject.Find("Random skin").GetComponent<Image>().enabled = false;
        GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Random skin").transform.GetChild(1).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Yaaaay button").GetComponent<Image>().enabled = false;
        GameObject.Find("Yaaaay button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
    }

    private void DisableObjects()
    {
        GameObject.Find("Current skin").GetComponent<Image>().enabled = false;
        GameObject.Find("Browse skins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Browse skins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(1).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Buy random skin button").transform.GetChild(2).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Buy coins button").GetComponent<Image>().enabled = false;
        GameObject.Find("Buy coins button").transform.GetChild(0).gameObject.GetComponent<Text>().enabled = false;
        GameObject.Find("Current skin").GetComponent<Image>().enabled = false;
        GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("Current skin").GetComponent<Image>().enabled = false;
        GameObject.Find("Current skin").transform.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
        GameObject.Find("House icon").GetComponent<Image>().enabled = false;
        DisableBuyRandomSkin();
    }

    void Start()
    {
        //AdManager.ShowTopBanner(); Currently off
        PlayerPrefs.SetInt("Skin 1", 1);
        //PlayerPrefs.SetInt("Coins", 0);
        LoadData();
        LoadTextures();
        DisableObjects();
        DisableBrowseSkins();
        BallBehavior.Skinid = PlayerPrefs.GetString("Current skin");
        MusicStatus = false;
    }

    public void StartGame()
    {
        Load.Scene("Gameplay");
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void SkinsMenu()
    {
        DisableMainMenu();
        LoadSkinsMenu();
    }

    private void Debugger_Function()
    {
        if (BallBehavior.Skinid == "Skin 2") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin2Texture;
        else if (BallBehavior.Skinid == "Skin 3") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin3Texture;
        else if (BallBehavior.Skinid == "Skin 4") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin4Texture;
        else if (BallBehavior.Skinid == "Skin 5") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin5Texture;
        else if (BallBehavior.Skinid == "Skin 6") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin6Texture;
        else if (BallBehavior.Skinid == "Skin 7") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin7Texture;
        else if (BallBehavior.Skinid == "Skin 8") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin8Texture;
        else if (BallBehavior.Skinid == "Skin 9") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin9Texture;
        else if (BallBehavior.Skinid == "Skin 10") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin10Texture;
        else if (BallBehavior.Skinid == "Skin 11") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin11Texture;
        else if (BallBehavior.Skinid == "Skin 12") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin12Texture;
        else if (BallBehavior.Skinid == "Skin 13") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin13Texture;
        else if (BallBehavior.Skinid == "Skin 14") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin14Texture;
        else if (BallBehavior.Skinid == "Skin 15") GameObject.Find("Random skin").transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Skin15Texture;
    }
    private void NotEnoughCoins()
    {
        GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().text = "Buy random skin";
    }
    private void HaveAllSkins()
    {
        GameObject.Find("Buy random skin button").transform.GetChild(0).gameObject.GetComponent<Text>().text = "Buy random skin";
        GameObject.Find("Buy random skin button").transform.GetChild(1).gameObject.GetComponent<Text>().text = "100";
        GameObject.Find("Buy random skin button").transform.GetChild(2).gameObject.GetComponent<Image>().enabled = true;
    }

    public void HouseIcon()
    {

        if (PlayerPos == "Skins menu") DisableSkinsMenu();
        else if (PlayerPos == "Browse skins") DisableBrowseSkins();
        else if (PlayerPos == "Buy random skin")
        {
            DisableBuyRandomSkin();
            DisableSkinsMenu();
        }
        LoadMainMenu();
        PlayerPos = "Main menu";
    }

    public void SetSkin(string skin)
    {
        if ((PlayerPrefs.GetInt(skin) == 1))
        {
            BallBehavior.Skinid = skin;
            PlayerPrefs.SetString("Current skin", skin);
            DisableBrowseSkins();
            LoadSkinsMenu();
        }
    }

    public void Mute()
    {
        if (MusicStatus)
        {
            GameObject.Find("Music icon").GetComponent<Image>().sprite = MusicOFFTexture;
            GameObject.Find("Music").GetComponent<AudioSource>().mute = true;
            MusicStatus = false;
        }
        else
        {
            GameObject.Find("Music icon").GetComponent<Image>().sprite = MusicONTexture;
            GameObject.Find("Music").GetComponent<AudioSource>().mute = false;
            MusicStatus = true;
        }
    }
}