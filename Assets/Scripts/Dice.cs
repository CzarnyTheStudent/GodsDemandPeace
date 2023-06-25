using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Dice : MonoBehaviour 
{
    public int cubeValue;
    public GameObject[] objectsToCompare;
    public Rigidbody rb;
    
    //public MarkScript mS;
    public Collider markCollider;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();


        // Wyświetlenie nazwy najwyższego obiektu
      
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity == new Vector3(0, 0, 0))
        {
            GameObject highestObject = GetHighestObject(objectsToCompare);
            cubeValue = highestObject.GetComponent<Value>().valueY;

           
        }
    }
    
    private GameObject GetHighestObject(GameObject[] objects)
    {
        GameObject highestObject = null;
        float highestY = float.MinValue;

        // Iteracja przez wszystkie obiekty
        foreach (GameObject obj in objects)
        {
            // Sprawdzenie pozycji Y obiektu
            float objY = obj.transform.position.y;

            // Porównanie z dotychczasowym najwyższym obiektem
            if (objY > highestY)
            {
                highestY = objY;
                highestObject = obj;
            }
        }

        return highestObject;
    }

    
}
