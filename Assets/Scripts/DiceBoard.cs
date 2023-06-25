using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceBoard : MonoBehaviour
{
    public Animator diceBoard;
    public GameObject[] diceOnBoard;
    public Transform cubeBoard;
    private Camera mainCamera;
    private static readonly int ShowBoard = Animator.StringToHash("ShowBoard");

   
    private void Awake()
    {
        mainCamera = Camera.main;
        
    }
    
    void Start()
    {
        foreach (var i in diceOnBoard)
        {
            i.transform.SetParent(cubeBoard);
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            diceBoard.SetBool(ShowBoard, false);
        }
        if (Input.GetKeyDown("2"))
        {
            StartCoroutine(ChildGoBack());
            diceBoard.SetBool(ShowBoard, true);
        }
            
    }

    IEnumerator ChildGoBack()
    {
        yield return new WaitForSeconds(0.5f);
        foreach (var i in diceOnBoard)
        {
            cubeBoard.transform.DetachChildren();
            i.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

   
    private void PickUpDice()
    {
        foreach (GameObject dice in diceOnBoard)
        {
            //isHoldingDice = true;
            //dice.GetComponent<Rigidbody>().isKinematic = true;
            dice.transform.SetParent(mainCamera.transform);
        }
    }
}
