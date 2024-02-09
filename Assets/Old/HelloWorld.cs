using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        Debug.Log(GetRandomName());
    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Add")]
    void AddNumbers()
    {
        Debug.Log(Add(5, 3));
    }

    [ContextMenu("Print Name")]
    void Print()
    {
        Debug.Log(GetRandomName());
    }

    string GetRandomName()
    {
        int i = UnityEngine.Random.Range(1, 3);
        string name = "";
        switch (i)
        {
            case 1:
                name = "tom";
                break;
            case 2:
                name = "steve";
                break;
            default:
                name = "world";
                break;
        }
        return name;
    }

    int Add(int a1, int a2)
    {
        return int.Parse("5");
    }
}
