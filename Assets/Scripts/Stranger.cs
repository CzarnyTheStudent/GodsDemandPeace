using UnityEngine;
using UnityEngine.Serialization;

public enum BodyType : int
{
    Wolf = 0,
    Beak = 1, 
    Deer = 2,
    Ox = 3,
}

[System.Serializable]
public struct Question
{
    //public Client client;
    [TextArea(4, 8)]
    public string sentence;
}


[System.Serializable]
public struct LineAngry
{
    //public Client client;
    [TextArea(3, 8)]
    public string angrySentence;
}


[System.Serializable]
public struct LineHappy
{
    //public Client client;
    [TextArea(3, 8)]
    public string happySentence;
}


[CreateAssetMenu(fileName = "New Stranger", menuName = "Stranger")]
[System.Serializable]
public class Stranger : ScriptableObject
{
    
    public string nameClient;
    public Marks[] enumValue;
    public BodyType bodyType;

    public Marks[] GetEnumValue()
    {
        return enumValue;
    }

    public Question[] lines;
    public LineAngry[] angryLines;
    public LineHappy[] happyLines;
    



}