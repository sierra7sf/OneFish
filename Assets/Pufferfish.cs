using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pufferfish : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer spriteRenderer;
    float frameTimer;
    public float framesPerSecond = 5;
    int currentFrameIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        frameTimer = (1f / framesPerSecond);
        currentFrameIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;

        if (frameTimer <= 0)
        {
            currentFrameIndex++;
            if (currentFrameIndex >= sprites.Length)
            {
                currentFrameIndex = 0;
                return;
            }
            frameTimer = (1f / framesPerSecond);
            spriteRenderer.sprite = sprites[currentFrameIndex];
        }
    }
}
