using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float yMin = -3f; // ����������� �������� �� ��� Y
    public float yMax = 3f; // ������������ �������� �� ��� Y
    public float xMin = -2f;
    public float xMax = 2f;

    public void SpawnStarboker()
    {
        // ���������� ��������� �������� �� ��� Y � �������� ��������
        float randomY = Random.Range(yMin, yMax);
        float randomX = Random.Range(xMin, xMax);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        // ������� ������ ����������� � �������������� ��������� ������� �� ��� Y
        GameObject starboxer = GameObject.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}



