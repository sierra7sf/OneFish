using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRing : MonoBehaviour
{

    public float rotationSpeed;
    private bool button;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            if (counter == 3)
            {
                button = true;
            }

        }

        if (!button)
        {
            transform.Rotate(0, 0, 6.0f * rotationSpeed * Time.deltaTime);
        }
    }
}

