using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIExample : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        header.text = input.text;
    }

    public void DestroyCanvas()
    {
        Destroy(gameObject);
    }
}
