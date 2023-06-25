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
            isThrowed = true;
        }
    }

    private void ThrowDice()
    {
        if (!isThrowed)
        {
            foreach (GameObject dice in diceArray)
            {
                dice.transform.SetParent(null);

                // Wylosuj losowy kąt w zakresie od 0 do 360 stopni
                float randomAngle = Random.Range(-0.8f, 0.8f);

                // Zamień losowy kąt na wektor kierunku na płaszczyźnie XY
                Vector3 randomDirection = new Vector3(randomAngle, 0.2f, 1f);

                Rigidbody diceRigidbody = dice.GetComponent<Rigidbody>();

                // Zresetuj prędkość i moment obrotowy kostki
                diceRigidbody.velocity = Vector3.zero;
                diceRigidbody.angularVelocity = Vector3.zero;

                //diceRigidbody.isKinematic = false;
                diceRigidbody.AddForce(randomDirection * Random.Range(300f, 900f));
                diceRigidbody.AddTorque(Random.insideUnitSphere * 100f);
            }
        }
    }
}