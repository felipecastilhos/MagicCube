using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Cube>().PrintFromOutside();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
