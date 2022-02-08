using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public AudioClip myAudioClip;
    public SpriteRenderer mySpriteRenderer;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAudioClip = GetComponent<AudioClip>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        counter = 0;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ring"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
           // myAudioClip.Play();
           if(counter == 2)
            {
                rb.gravityScale = -1;
            }
            
        }
    }
}
