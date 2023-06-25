using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour
{
   
    public Marks[] enumsToCheck; 
    public Stranger[] anotherScript;
    public Metrics metrics;
    public CameraController cameraController;
    private int iiii;

    public void BeingClicable()
    {
        if (cameraController.isBookTime)
        {
            
            if (anotherScript != null)
            {
                for (int i = 0; i < anotherScript.Length; i++)
                {
                    iiii = i;
                }
                Marks[] enumValue = anotherScript[iiii].enumValue;

                bool isMatching = false;

                // Sprawdzenie, czy istnieje pasujący enum w obiekcie
                for (int i = 0; i < enumsToCheck.Length; i++)
                {
                    for (int j = 0; j < enumValue.Length; j++)
                    {
                        if (enumValue[j] == enumsToCheck[i])
                        {
                            isMatching = true;
                            break;
                        }
                    }
                }

                if (isMatching)
                {
                   // Debug.Log("Przynajmniej jedno dopasowanie enum zostało znalezione!");
                   metrics.CurrentControl++;
                   if (metrics.CurrentControl > 10)
                   {
                       Debug.Log("GameOver");
                   }
                }
                else
                {
                    //Nie znaleziono pasującego enum w obiekcie!"
                    metrics.CurrentControl--;
                    if (metrics.CurrentControl < -10)
                    {
                        Debug.Log("GameOver");
                    }
                }
            }
            else
            {
              
            }
        }
    }
    }
    
    
    

