using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioButton : MonoBehaviour
{
    public AudioSource audioSource;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        if (audioSource.volume == 0.0f)
        {
            spriteRenderer.color = Color.red;
            
            /*
            Color spr_co = spriteRenderer.color;
            spr_co.a = 1f;
            spriteRenderer.GetComponent<SpriteRenderer>().color = spr_co;
            */
            
            audioSource.volume = 1.0f;
        }
        else
        {
            spriteRenderer.color = Color.white;
            audioSource.volume = 0.0f;
        }


        
    }
}
