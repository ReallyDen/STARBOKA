using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionPointPoint : MonoBehaviour
{
    public Transform[] movePoints;   // ������ �����, �� ������� ������ ����� ���������
    public float speed = 2f;         // �������� ��������

    private int currentPointIndex = 0;

    void Start()
    {
        if (movePoints.Length > 0)
        {
            transform.position = movePoints[currentPointIndex].position;
        }
        else
        {
            Debug.LogError("No move points specified!");
        }
    }

    void Update()
    {
        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        if (movePoints.Length == 0)
            return;

        // �������� � ������� ���� � �������������� ��������
        transform.position = Vector2.MoveTowards(transform.position, movePoints[currentPointIndex].position, speed * Time.deltaTime);

        // ���� �������� ������� �����, ��������� � ���������
        if (Vector2.Distance(transform.position, movePoints[currentPointIndex].position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % movePoints.Length;
        }
    }
}