using UnityEngine;

public class ScoreAfterDeath : MonoBehaviour
{
	void Start ()
    {
        GetComponent<TextMesh>().text = "Score: " + BallBehavior.PlayerScore.ToString();
    }

}
