using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombinationButton : MonoBehaviour
{
    public TrackedMarks trackedMarks;
    public Button[] images;

    private int _choose;
    public CameraController cameraController;


    public void Awake()
    {
        MarkReset();
    }

    public void MarkReset()
    {
        for (int i = 0; i < images.Length; i++)
        {
            //images[i].image.color = Color.red;
            images[0].gameObject.gameObject.SetActive(false);
        }
        
    }

    private void Update()
    {
        if (!cameraController.isBookTime)
        {
            MarkReset();
        }


        //ButtonChecker();
        foreach (Marks mark in trackedMarks.trackedMarks)
        {
            if (cameraController.isBookTime)
            {

                switch (mark)
                {
                    case Marks.Eye:
                    case Marks.Moon:
                        _choose = 1;
                        //images[0].image.color = Color.green;
                        images[0].gameObject.gameObject.SetActive(true);
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Eye:
                    case Marks.Sun:
                        _choose = 2;
                        images[1].gameObject.gameObject.SetActive(true);
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Eye:
                    case Marks.Snake:
                        _choose = 3;
                        images[2].gameObject.gameObject.SetActive(true);
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Sun:
                    case Marks.Axe:
                        images[3].gameObject.gameObject.SetActive(true);
                        _choose = 4;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Cow: // nie krowa a jeleń
                    case Marks.Sun:
                        images[4].gameObject.gameObject.SetActive(true);
                        _choose = 5;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Moon:
                    case Marks.Maw:
                        images[5].gameObject.gameObject.SetActive(true);
                        _choose = 6;
                        break;
                    default:
                        break;
                }


                switch (mark)
                {
                    case Marks.Eye:
                    case Marks.Sun:
                        images[6].gameObject.gameObject.SetActive(true);
                        _choose = 7;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Axe:
                    case Marks.Cow:
                        images[7].gameObject.gameObject.SetActive(true);
                        _choose = 8;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Axe:
                    case Marks.Maw:
                        images[8].gameObject.gameObject.SetActive(true);
                        _choose = 9;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Tree:
                    case Marks.Snake:
                        images[9].gameObject.gameObject.SetActive(true);
                        _choose = 10;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Tree:
                    case Marks.Crown:
                        images[10].gameObject.gameObject.SetActive(true);
                        _choose = 11;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Snake:
                    case Marks.Cow:
                        images[11].gameObject.gameObject.SetActive(true);
                        _choose = 12;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Snake:
                    case Marks.Maw:
                        images[12].gameObject.gameObject.SetActive(true);
                        _choose = 13;
                        break;
                    default:
                        break;
                }

                switch (mark)
                {
                    case Marks.Maw:
                    case Marks.Crown:
                        images[13].gameObject.gameObject.SetActive(true);
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
                        images[14].gameObject.gameObject.SetActive(true);
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
                        images[15].gameObject.gameObject.SetActive(true);
                        _choose = 16;
                        break;
                    default:
                        break;
                }
            }
        }
    }
    





}