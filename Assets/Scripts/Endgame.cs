using UnityEngine;
using Functions;

public class Endgame : MonoBehaviour
{
	void Start ()
    {
        Invoke("FinishEndgame", 3);
    }
    void FinishEndgame()
    {
        Load.Scene("Menu");
    }
}
