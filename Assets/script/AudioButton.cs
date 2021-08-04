using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioButton : MonoBehaviour
{
    // 音とアイコン
    AudioSource audioSource;

    public Animator AnimCon;

    
    // 持っている音と、アイコンを持つ
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }


    // ボタンを押すと、音のON/OFF
    public void OnClick()
    {
        if (audioSource.volume == 0.0f)
        {
            //audioSource.time = 0.0f;
            audioSource.volume = 1.0f;
            AnimCon.SetBool("icon_bool",true);
        }
        else
        {
            audioSource.volume = 0.0f;
            AnimCon.SetBool("icon_bool",false);
        }
    }
}
