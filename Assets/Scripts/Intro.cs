using UnityEngine;
using Functions;

public class Intro : MonoBehaviour
{
	void Start ()
    {
        Invoke("StartGame", 2);
    }

    void StartGame()
    {
        Load.Scene("Menu");
    }
}
