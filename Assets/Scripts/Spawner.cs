using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public void SpawnStarboker()
    {
        GameObject starboxer = GameObject.Instantiate(prefabToSpawn, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}
