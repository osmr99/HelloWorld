using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] int number = 234;
    // Start is called before the first frame update
    void Start()
    {
        switch(number)
        {
            case 1:
                Debug.Log("1");
                Debug.Log("1");
                Debug.Log("1");
                Debug.Log("1");
                Debug.Log("1");
                Debug.Log("1");
                break;
            case 2:
            case 3:
                Debug.Log("2 or 3");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
