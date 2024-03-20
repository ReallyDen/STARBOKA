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
        // �������� ���� �� ������������
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ������������ ����� �������
        float newX = Mathf.Clamp(transform.position.x + horizontalInput * speed * Time.deltaTime, minX, maxX);
        float newY = Mathf.Clamp(transform.position.y + verticalInput * speed * Time.deltaTime, minY, maxY);

        // ��������� ������� �������
        transform.position = new Vector3(newX, newY, transform.position.z);
    }

    // ������������ ������ � ��������� Unity
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        // ������� �������
        Gizmos.DrawLine(new Vector3(minX, maxY, 0), new Vector3(maxX, maxY, 0));
        // ������ �������
        Gizmos.DrawLine(new Vector3(minX, minY, 0), new Vector3(maxX, minY, 0));
        // ����� �������
        Gizmos.DrawLine(new Vector3(minX, minY, 0), new Vector3(minX, maxY, 0));
        // ������ �������
        Gizmos.DrawLine(new Vector3(maxX, minY, 0), new Vector3(maxX, maxY, 0));
    }
}