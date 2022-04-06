using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Scenes;

    public int selectedScene;

    void Start()
    {
        Instantiate(Scenes[0], new Vector3(0, 0, 0), Quaternion.identity);
        SpawnScene(new Vector3(0, 10, 0));
    }
    
    public void SpawnScene(Vector3 spawnPos)
    {
        selectedScene = Random.Range(1, 3);
        Instantiate(Scenes[selectedScene], spawnPos, Quaternion.identity);
    }
}
