using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the movement speed as needed

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction based on the player's input
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);

        if (moveDirection != Vector3.zero)
        {
            // Rotate the player to face the movement direction
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }

        // Apply movement
        characterController.SimpleMove(moveDirection.normalized * moveSpeed);
    }
}


