using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsPlayer : MonoBehaviour
{
    public int score = 0;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
            //score = score + 1;
            score++;
            if (score == 5)
            {
                Debug.Log("You Win!");
            }
        }
    }
}
