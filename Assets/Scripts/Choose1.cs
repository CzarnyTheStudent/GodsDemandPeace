using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose1 : MonoBehaviour
{
   
    public Marks[] enumsToCheck;
    public Stranger anotherScript;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (anotherScript != null)
            {
                Marks[] enumValue = anotherScript.GetEnumValue();

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
                    Debug.Log("Przynajmniej jedno dopasowanie enum zostało znalezione!");
                }
                else
                {
                    Debug.Log("Nie znaleziono pasującego enum w obiekcie!");
                }
            }
            else
            {
                Debug.Log("AnotherScript nie został przypisany do skryptu EnumChecker!");
            }
        }
    }
    }
    
    
    

