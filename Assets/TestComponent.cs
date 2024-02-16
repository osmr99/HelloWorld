using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    [SerializeField] string text;
    OtherTest other; 
    // Start is called before the first frame update
    void Start()
    {
        other = FindObjectOfType<OtherTest>();
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        if (other != null)
            Debug.Log(other.Amount);
    }
}
