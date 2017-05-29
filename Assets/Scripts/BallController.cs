using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rig;

    void Start()
    {
        BallBehavior.ResetGameValues();
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (BallBehavior.Started && !BallBehavior.Dead)
        {
            /* Phone Settings */

            foreach (Touch touch in Input.touches)
             {
                 if (touch.position.x < Screen.width / 2) transform.position -= new Vector3(BallBehavior.LeftRightSpeed * Time.deltaTime, 0, 0);
                 else if (touch.position.x > Screen.width / 2) transform.position += new Vector3(BallBehavior.LeftRightSpeed * Time.deltaTime, 0, 0);
             }
             if(BallBehavior.Started) transform.position += new Vector3(0, BallBehavior.UpSpeed * Time.deltaTime, 0);

            /* PC Settings */
            /*
            if (Input.GetKey(KeyCode.A)) transform.position -= new Vector3(BallBehavior.LeftRightSpeed * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.D)) transform.position += new Vector3(BallBehavior.LeftRightSpeed * Time.deltaTime, 0, 0);
            transform.position += new Vector3(0, BallBehavior.UpSpeed * Time.deltaTime, 0);
            */
        }
    }
}
