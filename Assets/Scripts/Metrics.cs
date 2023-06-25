using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Metrics : ScriptableObject
{
    public int Control = 0;
    public int ControlMax = 5;
    public int ControlMin = -5;
    public int DeusVult = 0;
    public int DeusVultMax = 10;
    public int DeusVultMin = -10;

    public int CurrentControl = 0;
    public int CurrentDeusVult = 0;

    public void IncreaseControl(int amount)
    {
        CurrentControl = Mathf.Clamp(CurrentControl + amount, ControlMin, ControlMax);
    }

    public void DecreaseControl(int amount)
    {
        CurrentControl = Mathf.Clamp(CurrentControl - amount, ControlMin, ControlMax);
    }

    public void IncreaseDeusVult(int amount)
    {
        CurrentDeusVult = Mathf.Clamp(CurrentDeusVult + amount, DeusVultMin, DeusVultMax);
    }

    public void DecreaseDeusVult(int amount)
    {
        CurrentDeusVult = Mathf.Clamp(CurrentDeusVult - amount, DeusVultMin, DeusVultMax);
    }
}