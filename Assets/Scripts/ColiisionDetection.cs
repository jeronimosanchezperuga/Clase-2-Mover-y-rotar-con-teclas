using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiisionDetection : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hubo colisión " + col.gameObject.name );
        Destroy(col.gameObject);
        Debug.Log("You Lose!");
    }

}
