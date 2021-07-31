using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class se_s : MonoBehaviour
{
    public AudioSource[] audioSource;
    
    SpriteRenderer spriteRenderer;


    public AudioSource[] audioSourceCheck;
    public GameObject ClearText;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSourceCheck[0].volume == 1.0f && audioSourceCheck[1].volume == 1.0f) {
            ClearText.SetActive(true);
        }
    }

    

    public void OnClick()
    {
        if (audioSource[0].volume == 0.0f)
        {
            spriteRenderer.color = Color.red;
            audioSource[0].volume = 1.0f;
            audioSource[1].volume = 1.0f;
        }
        else
        {
            spriteRenderer.color = Color.gray;
            audioSource[0].volume = 0.0f;
            audioSource[1].volume = 0.0f;
        }
    }
}
