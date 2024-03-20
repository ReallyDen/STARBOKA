using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsatingObject : MonoBehaviour
{
    public float pulsationSpeed = 1.0f; // �������� ���������, ������� ����� ��������� � ����������
    public float pulsationAmplitude = 0.1f; // ��������� ���������, �� ��������� ������ ����� ������������� � �����������

    private Vector3 initialScale; // ��������� ������ �������

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // ���������� Mathf.Sin ��� �������� ���������
        float pulsation = Mathf.Sin(Time.time * pulsationSpeed) * pulsationAmplitude;

        // ��������� ��������� � ������� �������
        transform.localScale = initialScale + new Vector3(pulsation, pulsation, 0);
    }
}