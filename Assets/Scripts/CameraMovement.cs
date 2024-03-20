using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5f;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -5f;
    public float maxY = 5f;

    void Update()
    {
        // Получаем ввод от пользователя
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Рассчитываем новую позицию
        float newX = Mathf.Clamp(transform.position.x + horizontalInput * speed * Time.deltaTime, minX, maxX);
        float newY = Mathf.Clamp(transform.position.y + verticalInput * speed * Time.deltaTime, minY, maxY);

        // Обновляем позицию объекта
        transform.position = new Vector3(newX, newY, transform.position.z);
    }

    // Визуализация границ в редакторе Unity
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        // Верхняя граница
        Gizmos.DrawLine(new Vector3(minX, maxY, 0), new Vector3(maxX, maxY, 0));
        // Нижняя граница
        Gizmos.DrawLine(new Vector3(minX, minY, 0), new Vector3(maxX, minY, 0));
        // Левая граница
        Gizmos.DrawLine(new Vector3(minX, minY, 0), new Vector3(minX, maxY, 0));
        // Правая граница
        Gizmos.DrawLine(new Vector3(maxX, minY, 0), new Vector3(maxX, maxY, 0));
    }
}