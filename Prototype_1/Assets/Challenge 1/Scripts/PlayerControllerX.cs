using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 1f;
    private float rotationSpeed = 50f; // Adjust this value to control the rotation speed
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed *Time.deltaTime*horizontalInput);

        // Tilt the plane up/down based on up/down arrow keys
        float rotation = verticalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.right, rotation);
    }
}
