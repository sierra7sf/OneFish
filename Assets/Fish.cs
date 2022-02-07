using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public AudioClip myAudioClip;
    public SpriteRenderer mySpriteRenderer;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAudioClip = GetComponent<AudioClip>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
           // myAudioClip.Play();
            rb.gravityScale = -1;
        }
    }
}
