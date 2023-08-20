using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    float horizontalMovement = 5f;
    float verticalMovement = 5f;

    public Rigidbody2D rigidbody2D;

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
        movementDetection();
        screenboundsPrinter();
    }

    void movementDetection()
    {
        float newXValue = 0.0f;
        float newYValue = 0.0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            newYValue += verticalMovement;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newXValue += horizontalMovement;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newYValue -= verticalMovement;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newXValue -= horizontalMovement;
        }

        rigidbody2D.velocity = new Vector2(newXValue, newYValue);
    }

    void screenboundsPrinter()
    {
        Resolution screenbounds = Screen.currentResolution;
        float verticalLimits = 4.6f;
        float horizontalLimits = 9.5f;
        if (transform.position.x > horizontalLimits || transform.position.x < horizontalLimits)
        {
            Debug.Log("Screenbounds:" + screenbounds.width);
            Debug.Log("The cube is out of the screen bounds");
        }

        if (transform.position.y > verticalLimits || transform.position.y < -verticalLimits)
        {
            Debug.Log("The cube is out of the screen bounds");
        }
    }
}
