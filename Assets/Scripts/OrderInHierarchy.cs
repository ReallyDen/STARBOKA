using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInHierarchy : MonoBehaviour
{
    private Transform parentTransform;

    void Start()
    {
        // Получаем родительский объект
        parentTransform = transform.parent;

        // Вызываем метод для установки начального порядка в иерархии
        UpdateHierarchyOrder();
    }

    void Update()
    {
        // Если произошли изменения в координатах объектов, обновляем порядок в иерархии
        UpdateHierarchyOrder();
    }

    void UpdateHierarchyOrder()
    {
        // Получаем все дочерние объекты родительского объекта
        int childCount = parentTransform.childCount;
        Transform[] children = new Transform[childCount];

        for (int i = 0; i < childCount; i++)
        {
            children[i] = parentTransform.GetChild(i);
        }

        // Сортируем дочерние объекты по Y-координате в порядке убывания
        System.Array.Sort(children, (t1, t2) => t2.position.y.CompareTo(t1.position.y));

        // Обновляем порядок в иерархии
        for (int i = 0; i < childCount; i++)
        {
            children[i].SetSiblingIndex(i);
        }
    }
}