using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject squarePrefab;
    [SerializeField] TMP_Text myText;
    int points;
    
    public int Points
    {
        get { return points; }
        set { points = value; myText.text = Points.ToString(); }
    }
    // Start is called before the first frame update
    void Start()
    {
        myText = FindObjectOfType<TMP_Text>();
        GameObject square = Instantiate(squarePrefab, transform);
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height);

        square.transform.position = new Vector2(x, y);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void AddPoints(int amount)
    {
        Points += amount;
        myText.text = Points.ToString();
    }*/
}
