using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = "Coins: " + PlayerPrefs.GetInt("Coins");
    }
}
