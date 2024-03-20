using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorObject : MonoBehaviour
{
    private bool isScaling = false;
    public float scaleSpeed = 25f; // Скорость изменения масштаба

    public void Mirror()
    {
        if (!isScaling)
        {
            StartCoroutine(SmoothScaleChange());
        }
    }

    IEnumerator SmoothScaleChange()
    {
        isScaling = true;

        Vector3 targetScale = transform.localScale;
        targetScale.x *= -1;

        while (transform.localScale != targetScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
            yield return null;
        }

        isScaling = false;

        Debug.Log("Нажимается");
    }
}