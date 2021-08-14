using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class AudioButton : MonoBehaviour
{
    // 音とアイコン
    AudioSource audioSource;

    public Animator AnimCon;
    public PlayableDirector playableDirector;

    bool se_on_off = false;
    private bool _isEnabbleAnimation = false;

    
    // 持っている音と、アイコンを持つ
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        //AnimCon.enabled = false;
    }


    // ボタンを押すと、音のON/OFF
    public void OnClick()
    {
        if (se_on_off == false)
        {
            audioSource.volume = 1.0f;
            _isEnabbleAnimation = true;
            se_on_off = true;
        }
        else
        {
            audioSource.volume = 0.0f;
            _isEnabbleAnimation = false;
            se_on_off = false;
        }
    }

    
    void Update() {
        if(playableDirector != null){
            playableDirector.time = audioSource.time;
            if(_isEnabbleAnimation) playableDirector.Evaluate();
        }
    }
    
}
