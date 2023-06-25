using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGogs : MonoBehaviour
{
    public Transform arrowTransform;
    public float maxRotationAngle = 30f;
    public float maxValue = 5f;
    public Metrics metrics;

    private void Update()
    {
        // Odczytaj wartość z systemu wartości od -5 do +5 (zmień "yourValue" na odpowiednią zmienną, która przechowuje wartość)
        float value = metrics.CurrentDeusVult;

        // Oblicz kąt obrotu na podstawie wartości
        float rotationAngle = value / maxValue * maxRotationAngle;

        // Ogranicz kąt obrotu do zakresu od -maxRotationAngle do maxRotationAngle
        rotationAngle = Mathf.Clamp(rotationAngle, -maxRotationAngle, maxRotationAngle);

        // Ustaw nową rotację strzałki
        arrowTransform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
    }
}
