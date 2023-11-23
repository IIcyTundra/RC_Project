using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    void Start()
    {
        string scene = "MainMenu";
        gameObject.GetComponent<ViewManager>().PlayScene(scene);
        Invoke("MakeSceneActive", 0.03f);
    }

    private void MakeSceneActive()
    {
        if (SceneManager.GetSceneByName("MainMenu").isLoaded)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));
            Debug.Log("SceneActive");
        }
            
    }







}
