using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hubo colisión " + col.gameObject.name );
        Destroy(col.gameObject);
        Debug.Log("You Lose!");
    }

}
