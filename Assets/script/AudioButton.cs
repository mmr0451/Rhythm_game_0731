using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioButton : MonoBehaviour
{
    // 音とアイコン
    AudioSource audioSource;

    public Animator AnimCon;

    private float PlayTime;

    
    // 持っている音と、アイコンを持つ
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        AnimCon.enabled = false;
    }


    // ボタンを押すと、音のON/OFF
    public void OnClick()
    {
        if (audioSource.volume == 0.0f)
        {
            //audioSource.time = 0.0f;
            audioSource.volume = 1.0f;
            //AnimCon.SetBool("icon_bool",true);
            AnimCon.enabled = true;

            PlayTime = Mathf.Lerp(0, 1, Mathf.Repeat(audioSource.time, 2)); 
            AnimCon.Play(AnimCon.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, PlayTime);

            /*
            PlayTime = Mathf.Lerp(0, 1, Mathf.Repeat(audioSource.time, 2)); 
            Debug.Log("補完値　　" + PlayTime);
            
            AnimCon.Play(AnimCon.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, PlayTime);
            */

            //PlayTime = Mathf.Lerp(1, 0, Mathf.Repeat(audioSource.time, 2)); 
            //Debug.Log("補完値　　" + PlayTime);

            /*
            AnimatorStateInfo animeStateInfo = AnimCon.GetCurrentAnimatorStateInfo(0);
            float degrees = Mathf.Lerp(2, 0, Mathf.Repeat(animeStateInfo.normalizedTime, 1)); 
            //AnimCon.Play(AnimCon.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, Random.Range(0f, 1f));
            AnimCon.Play(AnimCon.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, degrees);
    
            Debug.Log("アニメの時間   " + degrees);
            */
        }
        else
        {
            audioSource.volume = 0.0f;
            //AnimCon.SetBool("icon_bool",false);
            AnimCon.enabled = false;
        }
    }

    
    void Update() {
        //PlayTime = Mathf.Lerp(1, 0, Mathf.Repeat(audioSource.time, 2)); 
        //PlayTime = Mathf.Lerp(0, 1, Mathf.Repeat(audioSource.time, 2)); 
        //Debug.Log("補完値　　" + PlayTime);
    }
    
}
