using UnityEngine;
using Functions;

public class House : MonoBehaviour
{
    void OnMouseDown()
    {
        Load.Scene("Menu");
        Destroy(GameObject.Find("Music"));
    }
}
