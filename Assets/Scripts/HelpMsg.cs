using UnityEngine;

public class HelpMsg : MonoBehaviour
{
    void Update()
    {
        if (BallBehavior.Started == true) gameObject.SetActive(false);
    }
}
