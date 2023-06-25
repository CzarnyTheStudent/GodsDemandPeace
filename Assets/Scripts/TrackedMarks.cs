using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TrackedMarks : ScriptableObject
{
    public HashSet<Marks> trackedMarks = new HashSet<Marks>();
    
    
    
}
