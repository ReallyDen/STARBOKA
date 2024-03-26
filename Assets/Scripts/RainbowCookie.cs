using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowCookie : MonoBehaviour
{
    public Transform[] detectionPoints; // ������ ����� �����������
    public GameObject panelToActivate; // ������ ��� ���������
    public GameObject deliteRitual;
    public GameObject deliteRitual2;

    void Update()
    {
        bool allPointsOccupied = true; // ������������, ��� ��� ����� ������

        // ��������� ������ �����
        foreach (Transform point in detectionPoints)
        {
            // ��������� ������� �������� � ����� "poop" �� ������� �����
            Collider2D[] colliders = Physics2D.OverlapPointAll(point.position);
            bool pointOccupied = false;
            foreach (Collider2D collider in colliders)
            {
                if (collider.CompareTag("cookie"))
                {
                    pointOccupied = true;
                    break;
                }
            }

            // ���� ���� �� ���� ����� �� ������, ������� �� �����
            if (!pointOccupied)
            {
                allPointsOccupied = false;
                break;
            }
        }

        // ���� ��� ����� ������, ���������� ������
        if (allPointsOccupied)
        {
            panelToActivate.SetActive(true);
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("poop");
            GameObject[] objectsWithTag1 = GameObject.FindGameObjectsWithTag("cookie");
            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
            }
            foreach (GameObject obj1 in objectsWithTag1)
            {
                Destroy(obj1);
            }
            Destroy(deliteRitual);
            Destroy(deliteRitual2);
        }
    }
}