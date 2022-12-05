using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void changeSceneChase()
    {
        SceneManager.LoadScene("Chase");
    }
    public void changeSceneHome()
    {
        SceneManager.LoadScene("Title");
    }

}
