using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterManager : MonoBehaviour
{
    public List<Stranger> visitorsList = new List<Stranger>();
    public GameObject[] skins;

    private Stranger chosenStranger = null;
    

    private void Update()
    {
        chosenStranger = GetRandomClient();
    }

    public Stranger GetRandomClient()
    {
        int randomClient = Random.Range(0, visitorsList.Count);
        List<Stranger> possibleClient = new List<Stranger>();
        foreach (Stranger client in visitorsList)
        {
            if (randomClient <= 7) //<= client.comeChance
            {
                possibleClient.Add(client);
            }
        }
        if (possibleClient.Count >= 0)
        {
            if (possibleClient.Count == 0)
            { return null; }
            Stranger chosenClient = possibleClient[Random.Range(0, possibleClient.Count)];
            return chosenClient;
        }
        //speaker.SetActive(false);
        return null;
    }

    public void ShowCharacter()
    {
        int i = chosenStranger.number;
        switch(i)
        {
            case 0: 
                Debug.Log("Wolf");
                skins[0].SetActive(true);
                skins[1].SetActive(false);
                skins[2].SetActive(false);
                skins[3].SetActive(false);
                break;
            case 1:
                Debug.Log("Beak");
                skins[1].SetActive(true);
                skins[0].SetActive(false);
                skins[2].SetActive(false);
                skins[3].SetActive(false);
                break;
            case 2:
                Debug.Log("Beak");
                skins[1].SetActive(false);
                skins[0].SetActive(false);
                skins[2].SetActive(true);
                skins[3].SetActive(false);
                break;
            case 3:
                Debug.Log("Beak");
                skins[1].SetActive(false);
                skins[0].SetActive(false);
                skins[2].SetActive(false);
                skins[3].SetActive(true);
                break;
            default:
                Debug.Log("NOTHING");
                break;
        }
    }
    
    
    
    
}
