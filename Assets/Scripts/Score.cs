using UnityEngine;

public class Score : MonoBehaviour
{
    void Start()
    {
        BallBehavior.ResetGameValues();
    }
    void Update()
    {
        if (BallBehavior.Started && !BallBehavior.Dead)
        {
            BallBehavior.PlayerScore++;
            GetComponent<TextMesh>().text = "Score: " + BallBehavior.PlayerScore.ToString();
        }
    }
 }
