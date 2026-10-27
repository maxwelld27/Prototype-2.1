using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xRange = 10;
    //Make a variable for the player's speed
    public float speed = 10.0f;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player inbounds
        if(transform.position.x < -xRange)
        {
            // Set the X position less than -10 so the player doesn't go off the sides of the platforms
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            
        }
        if (transform.position.x > xRange)
        {
            // Make the player's X position fixed but on the Z axis
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Move the player left and right based left and right arrow keys
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        
       
        

    }
}
