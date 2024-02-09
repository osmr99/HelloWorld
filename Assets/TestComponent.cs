using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    [SerializeField] string text;
    [SerializeField] string Other;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
