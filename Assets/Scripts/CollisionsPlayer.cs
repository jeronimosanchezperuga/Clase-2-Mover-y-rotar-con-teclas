using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionsPlayer : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI txtScore;

    void Start()
    {
        txtScore.text = "0";
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
            //score = score + 1;
            score++;
            txtScore.text = score.ToString();
                
            if(score == 2)
            {
                txtScore.text = "You Win!!!";
            }
        }
    }
}
