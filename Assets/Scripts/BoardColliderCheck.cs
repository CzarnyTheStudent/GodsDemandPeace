using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardColliderCheck : MonoBehaviour
{
   public CombinationButton combinationButton;
   private bool isMoving = false;
   private Vector3 previousPosition;
   

   private void Start()
   {
      previousPosition = transform.position;
   }

   private void FixedUpdate()
   {
      // Sprawdzanie poruszania się obiektu
      if (transform.position != previousPosition)
      {
         isMoving = true;
      }
      else
      {
         isMoving = false;
      }

      previousPosition = transform.position;
   }

   private void OnTriggerEnter(Collider other)
   {
      if (isMoving)
      {
         combinationButton.MarkReset();
      }
   }
   

   
    
    
}
