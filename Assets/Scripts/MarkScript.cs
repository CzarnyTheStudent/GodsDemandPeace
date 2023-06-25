using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum Marks
{
    Eye = 0,
    Sun = 1,
    Moon = 2,
    Axe = 3,
    Tree = 4,
    Snake = 5,
    Cow = 6,
    Maw = 7,
    Crown = 8,
}
[Flags]
public enum dupa
{
    Blada = 1 << 0,
    Big = 1 << 1,
    Smol = 1 << 2,
    Medium = 1 << 3
}

public static class DupaExtensions
{
    public static bool HasFlagFast(this dupa value, dupa flag)
    {
        return (value & flag) != 0;
    }
}

public class MarkScript : MonoBehaviour
{
    public Marks mark;
    public int[] chooseMade;
    public TrackedMarks trackedMarks;
    public List<GameObject> dice = new List<GameObject>();
    public string parentObjectName;


    private void Start()
    {
        //if(dupa.HasFlagFast(dupa.Blada | dupa.Medium))
            //return;
    }

    private void Update()
    {
        foreach (Marks marks in trackedMarks.trackedMarks)
        {
        }
    }
    public GameObject GetParentWithoutIsTrigger(GameObject childObject)
    {
        Transform parentTransform = childObject.transform.parent;

        while (parentTransform != null)
        {
            Collider parentCollider = parentTransform.GetComponent<Collider>();

            if (parentCollider != null && !parentCollider.isTrigger)
            {
                return parentTransform.gameObject;
            }

            parentTransform = parentTransform.parent;
        }

        return null;
    }
    
    private void OnTriggerEnter (Collider _dice)
    {
        if (_dice.isTrigger)
        {

            GameObject parentObject = GetParentWithoutIsTrigger(_dice.gameObject);
            if (parentObject != null)
            {
                 parentObjectName = parentObject.name;

                // Wyświetl nazwę nadrzędnego obiektu w konsoli
                Debug.Log("Nazwa nadrzędnego obiektu: " + parentObjectName);
            }
            

        }
        
       
        
        
        switch ((int)mark)
            {
                case 0:
                    trackedMarks.trackedMarks.Add(Marks.Eye);
                    break;
                case 1:
                    trackedMarks.trackedMarks.Add(Marks.Sun);
                    break;
                case 2:
                    trackedMarks.trackedMarks.Add(Marks.Moon);
                    break;
                case 3:
                    trackedMarks.trackedMarks.Add(Marks.Axe);
                    break;
                case 4:
                    trackedMarks.trackedMarks.Add(Marks.Tree);
                    break;
                case 5:
                    trackedMarks.trackedMarks.Add(Marks.Snake);
                    break;
                case 6:
                    trackedMarks.trackedMarks.Add(Marks.Cow);
                    break;
                case 7:
                    trackedMarks.trackedMarks.Add(Marks.Maw);
                    break;
                case 8:
                    trackedMarks.trackedMarks.Add(Marks.Crown);
                    break;
                default:
                    break;
            }
    }

    private void OnTriggerExit(Collider _dice)
    {
        switch ((int)mark)
        {
            case 0:
                trackedMarks.trackedMarks.Remove(Marks.Eye);
                break;
            case 1:
                trackedMarks.trackedMarks.Remove(Marks.Sun);
                break;
            case 2:
                trackedMarks.trackedMarks.Remove(Marks.Moon);
                break;
            case 3:
                trackedMarks.trackedMarks.Remove(Marks.Axe);
                break;
            case 4:
                trackedMarks.trackedMarks.Remove(Marks.Tree);
                break;
            case 5:
                trackedMarks.trackedMarks.Remove(Marks.Snake);
                break;
            case 6:
                trackedMarks.trackedMarks.Remove(Marks.Cow);
                break;
            case 7:
                trackedMarks.trackedMarks.Remove(Marks.Maw);
                break;
            case 8:
                trackedMarks.trackedMarks.Remove(Marks.Crown);
                break;
            default:
                break;
        }
    }
    
    
    
    
    
}
