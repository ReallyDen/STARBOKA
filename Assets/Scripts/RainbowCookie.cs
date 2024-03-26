using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowCookie : MonoBehaviour
{
    public Transform[] detectionPoints; // Массив точек обнаружения
    public GameObject panelToActivate; // Панель для активации
    public GameObject deliteRitual;
    public GameObject deliteRitual2;

    void Update()
    {
        bool allPointsOccupied = true; // Предполагаем, что все точки заняты

        // Проверяем каждую точку
        foreach (Transform point in detectionPoints)
        {
            // Проверяем наличие объектов с тегом "poop" на текущей точке
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

            // Если хотя бы одна точка не занята, выходим из цикла
            if (!pointOccupied)
            {
                allPointsOccupied = false;
                break;
            }
        }

        // Если все точки заняты, активируем панель
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