using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    private int score_int = 0;
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Prop")
        {
            score_int = score_int + 100;
        }
        if (collision.gameObject.tag == "Family")
        {
            score_int = score_int - 1000;
        }
    }
    // Update is called once per frame
    void Update()
    {
        score.text = score_int.ToString();
    }
}
