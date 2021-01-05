using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoad : MonoBehaviour
{
    public void loadScene()
    {
        int getSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (getSceneIndex == 2)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(getSceneIndex + 1);
        }
        
    }
}
