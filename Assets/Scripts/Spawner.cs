using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Walls;
    private int WallsSpawned;
    private GameObject instantiatedObj;
    float y = 3;

    void Start()
    {
        GameObject.Find("Walls").transform.position = new Vector3(999, 999, 999);
        WallsSpawned = 0;
    }
    void Update()
    {
        float x = Random.Range(26.2f, 35.4f);
        if (WallsSpawned < 500)
        {
            instantiatedObj = (GameObject) Instantiate(Walls, new Vector3(x, y * 5f, 0), Quaternion.identity);
            Walls.name = "Walls N:" + WallsSpawned;
            WallsSpawned++;
            y +=6;
        }
    }
}
