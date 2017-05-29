using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Endgame") Destroy(this.gameObject);
    }
}
