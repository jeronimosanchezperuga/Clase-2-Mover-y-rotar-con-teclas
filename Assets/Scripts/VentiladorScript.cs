using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentiladorScript : MonoBehaviour
{
    public float rotationSpeed;
    public bool isOn = true;

    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            transform.Rotate(0, 0, rotationSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOn = !isOn;
        }
        
    }
}
