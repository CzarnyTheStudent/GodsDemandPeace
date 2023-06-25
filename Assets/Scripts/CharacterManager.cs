using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterManager : MonoBehaviour
{
    public List<Stranger> visitorsList = new List<Stranger>();
    public GameObject[] skins;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    

    private Stranger chosenStranger = null;

    private void Awake()
    {
        anim1.SetBool("Go", false);
        anim2.SetBool("Go", false);
        anim3.SetBool("Go", false);
        anim4.SetBool("Go", false);
    }

    private void Update()
    {
        
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
        
        chosenStranger = GetRandomClient();
        int i = (int)chosenStranger.bodyType;
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
                Debug.Log("Deer");
                skins[1].SetActive(true);
                skins[0].SetActive(false);
                skins[2].SetActive(false);
                skins[3].SetActive(false);
                break;
            case 2:
                Debug.Log("Ox");
                skins[1].SetActive(false);
                skins[0].SetActive(false);
                skins[2].SetActive(true);
                skins[3].SetActive(false);
                break;
            case 3:
                Debug.Log("Boar");
                skins[1].SetActive(false);
                skins[0].SetActive(false);
                skins[2].SetActive(false);
                skins[3].SetActive(true);
                break;
            default:
                Debug.Log("NOTHING");
                break;
        }
        
        anim1.SetBool("Go", true);
        anim2.SetBool("Go", true);
        anim3.SetBool("Go", true);
        anim4.SetBool("Go", true);
    }

    public void Exit()
    {
        anim1.SetBool("Go", false);
        anim2.SetBool("Go", false);
        anim3.SetBool("Go", false);
        anim4.SetBool("Go", false);
    }

}
