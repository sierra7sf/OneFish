using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    //public AudioClip myAudioClip;
    public SpriteRenderer mySpriteRenderer;
    private float counter;
    private AudioSource myAudioSource;
    public AudioClip[] audioArray = new AudioClip[5];


    public Sprite[] frames;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAudioSource = GetComponent<AudioSource>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        counter = 0;


        int number2 = Random.Range(0, 5);
        AudioClip clip = audioArray[number2];
        myAudioSource.PlayOneShot(clip);

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
   
        int min = 0;
        int max = 9;
        int number = Random.Range(min, max);
        mySpriteRenderer.sprite = frames[number];


        if (Input.GetKeyDown(KeyCode.Space))
        {

       

            counter++;

  

            // myAudioClip.Play();
            if (counter == 2)
            {
   
                rb.gravityScale = -1;
            
            }
            
        }
    }
}
