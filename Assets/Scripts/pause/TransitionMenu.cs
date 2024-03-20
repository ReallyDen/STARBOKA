using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionMenu : MonoBehaviour
{
    public Transform object1;  // ������� ������1 � ����������
    public Transform object2;  // ������� ������2 � ����������
    public float smoothSpeed = 5f;  // �������� �������� �����������

    private bool isMouseOver = false;

    void Awake()
    {
        isMouseOver = false;
    }

    void Update()
    {
        Vector3 targetPosition = isMouseOver ? object2.position : object1.position;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }
}