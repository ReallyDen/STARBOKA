using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionMenu : MonoBehaviour
{
    public Transform object1;  // Задайте объект1 в инспекторе
    public Transform object2;  // Задайте объект2 в инспекторе
    public float smoothSpeed = 5f;  // Скорость плавного перемещения

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