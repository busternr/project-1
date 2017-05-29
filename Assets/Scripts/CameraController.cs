using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Rigidbody Camera;

    void Start()
    {
        BallBehavior.ResetGameValues();
        Camera = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (BallBehavior.Started && !BallBehavior.Dead) transform.position += new Vector3(0, BallBehavior.UpSpeed * Time.deltaTime, 0);
    }
}
