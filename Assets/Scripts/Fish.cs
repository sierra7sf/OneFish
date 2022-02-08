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
    private bool swim;


    public Sprite[] frames;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAudioSource = GetComponent<AudioSource>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        counter = 0;
        swim = false;
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ring"))
        {
            //Add "lost level" music
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {
            if (SceneManager.GetActiveScene().name == "LevelOne")
            {
                SceneManager.LoadScene("LevelTwo");
            }
            if (SceneManager.GetActiveScene().name == "LevelTwo")
            {
                SceneManager.LoadScene("LevelThree");
            }
            if (SceneManager.GetActiveScene().name == "LevelThree")
            {
                SceneManager.LoadScene("LevelFour");
            }
            if (SceneManager.GetActiveScene().name == "LevelFour")
            {
                SceneManager.LoadScene("Sierra");
            }
        }
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {

       

            counter++;

  

            // myAudioClip.Play();
            if (SceneManager.GetActiveScene().name == "LevelOne")
            {
                Debug.Log("LevelOne");
                if(counter == 1)
                {
                    swim = true;
                }
            
            }
            if (SceneManager.GetActiveScene().name == "LevelTwo")
            {
                if (counter == 2)
                {
                    swim = true;
                }

            }
            if (SceneManager.GetActiveScene().name == "LevelThree")
            {
                if (counter == 3)
                {
                    swim = true;
                }

            }

            if (SceneManager.GetActiveScene().name == "LevelFour")
            {
                if (counter == 4)
                {
                    swim = true;
                }

            }

        }

        if (swim)
        {
            /*int min = 0;
            int max = 2;
            int number = Random.Range(min, max);
            mySpriteRenderer.sprite = frames[number];*/

            int number2 = Random.Range(0, 5);
            AudioClip clip = audioArray[number2];
            myAudioSource.PlayOneShot(clip);

            rb.gravityScale = -1;

            swim = false;
        }
    }
}
