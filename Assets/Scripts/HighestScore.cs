using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    private Text ScoreText;
    void Start()
    {
        GetComponent<Text>().text = "Highest score: " + PlayerPrefs.GetInt("Highest Score");
    }
}
