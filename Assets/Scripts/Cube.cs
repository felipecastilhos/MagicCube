using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    int numberOfTimes = 5;
    string nameOfTheKey = "Enter";

    void Start()
    {
        Debug.Log("If you press the up arrow you will JUMP!!");
        Debug.Log("If you press the right arrow " + numberOfTimes + "you will MOVE!!");
        Debug.Log("If you press the " + nameOfTheKey + "nothing will happen");
        Debug.Log("If you smash the keyboard nothing happens, you will just cry");
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.UpArrow)) {
        Debug.Log("Moving Up");
       } else if(Input.GetKeyDown(KeyCode.RightArrow)) { 
        Debug.Log("Moving to the right");
       } else if(Input.GetKeyDown(KeyCode.DownArrow)) { 
        Debug.Log("Moving down");
       } else if(Input.GetKeyDown(KeyCode.LeftArrow)) { 
        Debug.Log("Moving to the left");
       }
    }
}
