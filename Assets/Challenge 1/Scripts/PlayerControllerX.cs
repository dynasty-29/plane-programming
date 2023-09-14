using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 40.0f;
    public float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the user's input for both vertical and horizontal movement
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement direction based on input
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        // Move the plane based on the input direction
        transform.Translate(movementDirection * speed * Time.deltaTime);

        // Calculate tilt angles for pitch (up/down) and roll (left/right)
        float tiltAngle = -verticalInput * rotationSpeed;
        float rollAngle = -horizontalInput * rotationSpeed;

        // Create rotations based on the calculated angles
        Quaternion targetRotation = Quaternion.Euler(tiltAngle, 0, rollAngle);

        // Smoothly interpolate between the current rotation and the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
