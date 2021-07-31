using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class se_s : MonoBehaviour
{
    // サンプル音
    public AudioSource[] SampleAudioSource;
    SpriteRenderer spriteRenderer;


    // 正解音
    public AudioSource[] audioSourceCheck;
    public GameObject ClearText;


    // 再生・停止のアイコン
    public Sprite icon_on;
    public Sprite icon_off;

    // フラグ
    bool SampleSoundBool = true;
    

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSourceCheck[2].volume == 0.0f && audioSourceCheck[3].volume == 0.0f) {
            if (audioSourceCheck[0].volume == 1.0f && audioSourceCheck[1].volume == 1.0f) {
                ClearText.SetActive(true);
            }
        }
    }

    

    public void OnClick()
    {
        if (SampleSoundBool == true)
        {
            for(int i = 0; i < SampleAudioSource.Length; i++){
                SampleAudioSource[i].volume = 1.0f;
            }
            //spriteRenderer.color = Color.red;
            spriteRenderer.sprite = icon_on;
            SampleSoundBool = false;
        } else
        {
            for(int i = 0; i < SampleAudioSource.Length; i++){
                SampleAudioSource[i].volume = 0.0f;
            }
            //spriteRenderer.color = Color.white;
            spriteRenderer.sprite = icon_off;
            SampleSoundBool = true;
        }
        /*
        if (SampleAudioSource[0].volume == 0.0f)
        {
            spriteRenderer.color = Color.red;
            SampleAudioSource[0].volume = 1.0f;
            SampleAudioSource[1].volume = 1.0f;
        }
        else
        {
            spriteRenderer.color = Color.gray;
            SampleAudioSource[0].volume = 0.0f;
            SampleAudioSource[1].volume = 0.0f;
        }
        */
    }
}
