using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public GameObject[] diceArray;
    private bool isThrowed = false;
    private Camera mainCamera;
    private RaycastHit hit;

    private void Awake()
    {
        mainCamera = Camera.main;
     
    }

    private void Update()
    {

        if (Input.GetMouseButtonUp(1))
        {
                ThrowDice();
            isThrowed= true;
        }
    }


    private void ThrowDice()
    {
        if (!isThrowed)
        {
            foreach (GameObject dice in diceArray) 
            {
                //dice.GetComponent<Rigidbody>().isKinematic = false;
                dice.transform.SetParent(null);
                dice.GetComponent<Rigidbody>().AddForce(mainCamera.transform.forward * Random.Range(700f, 1000f));
                dice.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere * 200f);
            
            }
        }
    }
}