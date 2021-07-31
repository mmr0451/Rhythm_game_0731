using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void Scene_Stage1() {
        SceneManager.LoadScene("Stage1");
    }

    
    public void Scene_Title() {
        SceneManager.LoadScene("TitleScene");
    }

}
