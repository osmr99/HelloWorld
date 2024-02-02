using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIExample : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(string s)
    {
        header.text = s;
    }
}
