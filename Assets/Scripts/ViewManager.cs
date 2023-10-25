using Hertzole.ScriptableValues;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ViewManager: MonoBehaviour
{

    public ScriptableString sceneName;
    public void PlayScene()
    {
        SceneManager.LoadSceneAsync(sceneName.Value, LoadSceneMode.Additive);
    }

    public void UnloadScene()
    {
        SceneManager.UnloadSceneAsync(sceneName.Value);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
