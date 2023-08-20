using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    readonly float horizontalMovement = 5f;
    readonly float verticalMovement = 5f;

    public Rigidbody2D myRigidBody;

    void Start()
    {
        Debug.Log("If you press the up arrow you will JUMP!!");
        Debug.Log("If you press the right or left arrow you will move horizontally");
        Debug.Log("If you press down will you fall if you are too high");
        Debug.Log("If you smash the keyboard nothing happens, you will just cry");
    }

    // Update is called once per frame
    void Update()
    {
        MovementDetection();
        ScreenboundsPrinter();
    }

    void MovementDetection()
    {
        if (Input.anyKey)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector2 movementDirection = new Vector2(horizontalInput, verticalInput).normalized;

            if (movementDirection.sqrMagnitude > 0) myRigidBody.velocity = movementDirection * Mathf.Max(Mathf.Abs(horizontalMovement), Mathf.Abs(verticalMovement));
        }
    }

    void ScreenboundsPrinter()
    {
        Resolution screenbounds = Screen.currentResolution;
        float verticalLimits = 4.6f;
        float horizontalLimits = 9.5f;
        if (transform.position.x > horizontalLimits || transform.position.x < -horizontalLimits)
        {
            Debug.Log("Screenbounds:" + screenbounds.width);
            Debug.Log("The cube is out of the screen bounds");
        }

        if (transform.position.y > verticalLimits || transform.position.y < -verticalLimits)
        {
            Debug.Log("The cube is out of the screen bounds");
        }
    }

    public void PrintFromOutside()
    {
        Debug.Log("Cube is being controlled from misterious forces.");
    }
}
