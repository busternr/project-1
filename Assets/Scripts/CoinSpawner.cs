using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public static int CoinsSpawned;
    public GameObject[] InstantiatedCoin;
    float y = 30;
    void Start()
    {
        Coin.transform.position = new Vector3(999, 999, 999);
        InstantiatedCoin = new GameObject[200];
        CoinsSpawned = 0;
    }
    void Update()
    {
        float x = Random.Range(-8.5f, 5f);
        int SpawnChance = Random.Range(1,100);
        if (CoinsSpawned < 200)
        {
            if (SpawnChance >= 50)
            {
                y -= 30;
                //Instantiate(Coin, new Vector3(x, y * 5f, 0), Quaternion.identity); // random unity bugs
                InstantiatedCoin[CoinsSpawned] = (GameObject)Instantiate(Coin);
                Coin.transform.position = new Vector3(0, y * 5f, 0);
                Coin.name = "Coin N:" + CoinsSpawned;
                Coin.gameObject.tag = "Coin";
                y += 30;
            }
            y += 30;
            CoinsSpawned++; //For debugging purposes.Not a real counter.
        }
    }
}