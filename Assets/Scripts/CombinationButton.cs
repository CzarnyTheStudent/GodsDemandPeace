using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombinationButton : MonoBehaviour
{
    public TrackedMarks trackedMarks;
    public Button[] images;

    private int _choose;


    public void Awake()
    {
        MarkReset();
    }

    public void MarkReset()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].image.color = Color.red;
        }
    }
    private void Update()
    {
        //MarkReset();
        //ButtonChecker();
        foreach (Marks mark in trackedMarks.trackedMarks)
        {
           
            switch (mark)
            {
                case Marks.Eye:
                case Marks.Moon:
                      _choose = 1;
                      images[0].image.color = Color.green;
                    break;
                default:
                    break;
            }

            switch (mark)
            {
                case Marks.Eye:
                case Marks.Sun:
                _choose = 2;
                //images[1].enabled = true;
                break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Eye:
                case Marks.Snake:
                    _choose = 3;
                    //images[2].enabled = true;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Sun:
                case Marks.Axe:
                    _choose = 4;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Cow: // nie krowa a jeleń
                case Marks.Sun:
                    _choose = 5;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Moon:
                case Marks.Maw:
                    _choose = 6;
                    break;
                default:
                    break;
            }
            
            
            switch (mark)
            {
                case Marks.Eye:
                case Marks.Sun:
                    _choose = 7;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Axe:
                case Marks.Cow:
                    _choose = 8;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Axe:
                case Marks.Maw:
                    _choose = 9;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Tree:
                case Marks.Snake:
                    _choose = 10;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Tree:
                case Marks.Crown:
                    _choose = 11;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Snake:
                case Marks.Cow:
                    _choose = 12;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Snake:
                case Marks.Maw:
                    _choose = 13;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Maw:
                case Marks.Crown:
                    _choose = 14;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Tree:
                case Marks.Eye:
                case Marks.Sun:
                    _choose = 15;
                    break;
                default:
                    break;
            }
            
            switch (mark)
            {
                case Marks.Axe:
                case Marks.Maw:
                case Marks.Tree:
                    _choose = 16;
                    break;
                default:
                    break;
            }
        }
    }

    
    /**
    void ButtonChecker()
    {
        foreach (var button in buttons)
        {
            button.enabled = false;
        }
        switch (_choose)
        {
            case 1:
                buttons[_choose].enabled = true;
                Debug.Log("działa 1");
                break;
            case 2:
                buttons[_choose].enabled = true;
                Debug.Log("działa 2");
                break;
            case 3:
                buttons[_choose].enabled = true;
                Debug.Log("działa 3");
                break;
            case 4:
                buttons[_choose].enabled = true;
                Debug.Log("działa 4");
                break;

            default:
                

                break;
        }
    }
    
    **/
    
    
}