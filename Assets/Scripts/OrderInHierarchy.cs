using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInHierarchy : MonoBehaviour
{
    private Transform parentTransform;

    void Start()
    {
        // �������� ������������ ������
        parentTransform = transform.parent;

        // �������� ����� ��� ��������� ���������� ������� � ��������
        UpdateHierarchyOrder();
    }

    void Update()
    {
        // ���� ��������� ��������� � ����������� ��������, ��������� ������� � ��������
        UpdateHierarchyOrder();
    }

    void UpdateHierarchyOrder()
    {
        // �������� ��� �������� ������� ������������� �������
        int childCount = parentTransform.childCount;
        Transform[] children = new Transform[childCount];

        for (int i = 0; i < childCount; i++)
        {
            children[i] = parentTransform.GetChild(i);
        }

        // ��������� �������� ������� �� Y-���������� � ������� ��������
        System.Array.Sort(children, (t1, t2) => t2.position.y.CompareTo(t1.position.y));

        // ��������� ������� � ��������
        for (int i = 0; i < childCount; i++)
        {
            children[i].SetSiblingIndex(i);
        }
    }
}