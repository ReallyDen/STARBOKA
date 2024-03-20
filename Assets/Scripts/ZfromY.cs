using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZfromY : MonoBehaviour
{
    // ������ ����������� ��� ����������� �������� Z � ����������� �� Y
    public float depthMultiplier = -0.5f;

    void Update()
    {
        // �������� RectTransform ��������� �������
        RectTransform rectTransform = GetComponent<RectTransform>();

        // �������� ������� ���������� �������
        Vector3 currentPosition = rectTransform.anchoredPosition3D;

        // �������� �������� Z � ����������� �� Y, ��������� �����������
        currentPosition.z = currentPosition.y * depthMultiplier;

        // ��������� ����� ����������
        rectTransform.anchoredPosition3D = currentPosition;
    }
}