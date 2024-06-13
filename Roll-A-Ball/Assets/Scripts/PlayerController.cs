using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   public float movementSpeed = 5f; // Variable to control how fast the player moves
   public CharacterController controller; // Empty reference to the CharacterController component on the player


   // Start is called before the first frame update
   void Start()
   {
       controller = GetComponent<CharacterController>(); // Get the CharacterController component attached to the player
   }


   void FixedUpdate()
   {
       float horizontalInput = Input.GetAxis("Horizontal"); // Stores the Horizontal (Left & Right) input of the player
       float verticalInput = Input.GetAxis("Vertical"); // Stores the Vertical (Forward & Backward) input of the player


       Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput); // Calculate the direction the player should move based on the input
       movement = transform.TransformDirection(movement); // Convert the direction into local space; this means 'forward' will be relative to the direction the player is facing rather than the global 'forward'
       movement *= movementSpeed;


       controller.Move(movement * Time.deltaTime); // Move the player with the characterController component
   }
}








