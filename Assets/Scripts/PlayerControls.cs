using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    public float xLimit;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.x);
        //si el valor de la posicion en x es menor que 8
        //transform.position.x < xLimit
        if (Input.GetKey(KeyCode.D))
        {
            //acciones si la condicion se cumple
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //acciones si la condicion se cumple
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //acciones si la condicion se cumple
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //acciones si la condicion se cumple
            transform.Translate(0, -speed, 0);
        }

        //if (transform.position.x > xLimit)
        //{
        //    Destroy(gameObject);
        //}
    }

    //Requisitos para la detección de colisiones
    //1. Todos los gameObjects participantes en la colisión deben tener un componente Collider
    //2. Al menos uno de esos gameObjects debe tener un Rigidbody (2D o no según el caso)
    //3. Un script de detección de colisiones en alguno de los gameObjects participantes de la colisión


}
