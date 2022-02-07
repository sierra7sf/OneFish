using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    public float rotationSpeed;
    Rigidbody2D rb;
    private bool button;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            button = true; 
        }

        if (!button)
        {
            transform.Rotate(0, 0, 6.0f * rotationSpeed * Time.deltaTime);
        }
    }
}
