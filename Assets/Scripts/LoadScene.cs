using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public string currentScene;

    private int currentSceneInt;

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        
    }
    public void LoadByName(string sceneName)
    {
        SceneManager.GetSceneByName(sceneName);
    }
    public void FixedUpdate()
    {
        currentScene = SceneManager.GetActiveScene().name;
        currentSceneInt = SceneManager.GetActiveScene().buildIndex;
    }
}
