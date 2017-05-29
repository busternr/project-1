using UnityEngine;
using Functions;

public class BallBehavior : MonoBehaviour
{
    public static float LeftRightSpeed = 30;
    public static float UpSpeed = 20;
    public static bool Started;
    public static bool Dead;
    public static int PlayerScore;
    public static int HighestScore;
    public static int Coins;
    public static string Skinid;
    public static string DeadSkinid;
    private static int Debugger = 0;
    Texture2D AliveTexture;
    Texture2D DeadTexture;
    GameObject Player;
    public static void ResetGameValues()
    {
        Started = false;
        Dead = false;
        PlayerScore = 0;
        HighestScore = 0;
        UpSpeed = 20;
        Debugger = 0;
        Coins = PlayerPrefs.GetInt("Coins");
    }
    private void LoadResources()
    {
        AliveTexture = (Texture2D)Resources.Load(Skinid);
        if (Skinid == "Skin 1") DeadTexture = (Texture2D)Resources.Load("Dead 1");
        else if (Skinid == "Skin 2") DeadTexture = (Texture2D)Resources.Load("Dead 2");
        else if (Skinid == "Skin 3") DeadTexture = (Texture2D)Resources.Load("Dead 3");
        else if (Skinid == "Skin 4") DeadTexture = (Texture2D)Resources.Load("Dead 4");
        else if (Skinid == "Skin 5") DeadTexture = (Texture2D)Resources.Load("Dead 5");
        else if (Skinid == "Skin 6") DeadTexture = (Texture2D)Resources.Load("Dead 6");
        else if (Skinid == "Skin 7") DeadTexture = (Texture2D)Resources.Load("Dead 7");
        else if (Skinid == "Skin 8") DeadTexture = (Texture2D)Resources.Load("Dead 8");
        else if (Skinid == "Skin 9") DeadTexture = (Texture2D)Resources.Load("Dead 9");
        else if (Skinid == "Skin 10") DeadTexture = (Texture2D)Resources.Load("Dead 10");
        Player = GameObject.Find("Player");
    }
    void Start()
    {
        ResetGameValues();
        LoadResources();
        Player.GetComponent<Renderer>().material.mainTexture = AliveTexture;
    }
    void Update()
    {
        /* Phone Settings */
        foreach (Touch touch in Input.touches)
        {
            if (!Started) Started = true;
        }
        /* PC Settings */ if (Input.GetMouseButtonDown(0)) Started = true;
        if (Started) UpSpeed += Time.deltaTime/2;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Wall1" || collision.collider.name == "Wall2" || collision.collider.name == "bugged wall" || collision.collider.name == "Wall 1")
        {
            Invoke("FinishEndgame", 1);
            Dead = true;
            Player.GetComponent<Renderer>().material.mainTexture = DeadTexture;
            HighestScore = PlayerPrefs.GetInt("Highest Score");
            if (PlayerScore > HighestScore)
            {
                HighestScore = PlayerScore;
                PlayerPrefs.SetInt("Highest Score", HighestScore);
            }
            Coins += Debugger;
            PlayerPrefs.SetInt("Coins", Coins);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debugger++;
            Destroy(GameObject.Find(other.gameObject.name));
        }
    }
    void FinishEndgame()
    {
        Invoke("FinishEndgame2", 1);
        Load.Scene("Endgame");
    }
    void FinishEndgame2()
    {
        Load.Scene("Menu");
    }
}
