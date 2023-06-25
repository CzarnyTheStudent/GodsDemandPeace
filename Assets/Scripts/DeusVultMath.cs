using System;
using System.Collections;
using System.Collections.Generic;
using Choose;
using UnityEngine;
using UnityEngine.UI;

public class DeusVultMath : MonoBehaviour
{
   public ArrowGogs arrowGogs;
   public Dice[] dice;
   public List<BaseChoose> baseChooses;

   public MarkScript[] markScript;
   public Marks[] lastSetOfMarks;
   public Enum SavedMark;
   
   
   private void Awake()
   {
      for (int i = 0; i < baseChooses.Count; i++)
      {
         baseChooses[i].ChoiceClicked += SaveLastClickedChoises;
      }
   }

   private void Update()
   {
      Marks[] enums = lastSetOfMarks;
      bool isMatching = false;
      for (int i = 0; i < markScript.Length; i++)
      {
         for (int j = 0; j < enums.Length; j++)
         {
            if (enums[j] == markScript[i].mark)
            {
               SavedMark = markScript[i].mark;
               //Debug.Log(markScript[i]);
            }
         }
      }
      
      
      
   }

   private void SaveLastClickedChoises(Marks[] obj)
   {
      Debug.Log(obj.Length);
      lastSetOfMarks = obj;
   }
   
}
