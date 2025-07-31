using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Return : MonoBehaviour
{
    public void ReturnOnClick()
    {
        NextScene("StartScreen");
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
