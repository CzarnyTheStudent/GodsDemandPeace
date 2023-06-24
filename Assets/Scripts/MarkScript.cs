using System;
using System.Collections.Generic;
using UnityEngine;

public enum Marks : int
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
public class MarkScript : MonoBehaviour
{

    public Marks mark;
    HashSet<Marks> trackedMarks = new HashSet<Marks>();
    public List<GameObject> dice = new List<GameObject>();
   
    private void Update()
    {
        foreach (Marks marks in trackedMarks)
        {
            
            Debug.Log(marks + " is marked");
        }
    }

    private void OnTriggerEnter (Collider _dice)
    {
        switch ((int)mark)
            {
                case 0:
                    trackedMarks.Add(Marks.Eye);
                    break;
                case 1:
                    trackedMarks.Add(Marks.Sun);
                    break;
                case 2:
                    trackedMarks.Add(Marks.Moon);
                    break;
                case 3:
                    trackedMarks.Add(Marks.Axe);
                    break;
                case 4:
                    trackedMarks.Add(Marks.Tree);
                    break;
                case 5:
                    trackedMarks.Add(Marks.Snake);
                    break;
                case 6:
                    trackedMarks.Add(Marks.Cow);
                    break;
                case 7:
                    trackedMarks.Add(Marks.Maw);
                    break;
                case 8:
                    trackedMarks.Add(Marks.Crown);
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
                trackedMarks.Remove(Marks.Eye);
                break;
            case 1:
                trackedMarks.Remove(Marks.Sun);
                break;
            case 2:
                trackedMarks.Remove(Marks.Moon);
                break;
            case 3:
                trackedMarks.Remove(Marks.Axe);
                break;
            case 4:
                trackedMarks.Remove(Marks.Tree);
                break;
            case 5:
                trackedMarks.Remove(Marks.Snake);
                break;
            case 6:
                trackedMarks.Remove(Marks.Cow);
                break;
            case 7:
                trackedMarks.Remove(Marks.Maw);
                break;
            case 8:
                trackedMarks.Remove(Marks.Crown);
                break;
            default:
                break;
        }
    }
}
