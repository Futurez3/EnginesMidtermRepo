using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{

    public PluginHandler pluginHandler;

   public void TransitionScene(string sceneName)
    {
        if (sceneName == "PlayScene")
        {
            pluginHandler.ResetLog();
        }

        SceneManager.LoadScene(sceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }

  
}
