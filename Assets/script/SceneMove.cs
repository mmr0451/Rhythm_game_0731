using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void Scene_FreeMode() {
        SceneManager.LoadScene("StageFreeMode");
    }

    public void Scene_DaimonjiMode() {
        SceneManager.LoadScene("StageDaimonjiMode");
    }

    
    public void Scene_Title() {
        SceneManager.LoadScene("TitleScene");
    }

}
