using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioButton : MonoBehaviour
{
    // 音とアイコン
    AudioSource audioSource;
    SpriteRenderer spriteRenderer;

    
    // 持っている音と、アイコンを持つ
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }


    void Update()
    {

    }

    // ボタンを押すと、音のON/OFF
    public void OnClick()
    {
        if (audioSource.volume == 0.0f)
        {
            spriteRenderer.color = Color.red;
            audioSource.volume = 1.0f;
        }
        else
        {
            spriteRenderer.color = Color.white;
            audioSource.volume = 0.0f;
        }
    }
}
