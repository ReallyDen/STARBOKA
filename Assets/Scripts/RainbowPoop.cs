using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowPoop : MonoBehaviour
{
    public Transform[] detectionPoints; // ������ ����� �����������
    public GameObject panelToActivate; // ������ ��� ���������

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
                if (collider.CompareTag("poop"))
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
        }
        else
        {
            panelToActivate.SetActive(false);
        }
    }
}