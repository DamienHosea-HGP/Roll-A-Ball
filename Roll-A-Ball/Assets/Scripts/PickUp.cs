using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Pickup : MonoBehaviour
{
   public float rotateSpeed = 5f; // A var to augment the rotation speed of this pickup
  private void OnTriggerEnter(Collider other) // OnTriggerEnter() is called every time a collider marked as a trigger collides with another collider
  {
      if (other.gameObject.CompareTag("Player")) // If the collider this pickup just hit is tagged as the Player...
      {
           Destroy(this.gameObject); // Destroy this pickup!
      }
  }
    

  private void Update()
  {
       // Every frame, make this pickup rotate
       transform.Rotate(new Vector3(15, 30, 45) * rotateSpeed * Time.deltaTime);
  }
}












