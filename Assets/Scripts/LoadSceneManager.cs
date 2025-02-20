using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public static LoadSceneManager Instance { get; private set; }

    public string SceneName;
    public CharectorSystem Charector;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }
    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
    }

    public void LoadThisScene()
    {
        SceneManager.LoadScene(SceneName);

    }
    public void LoadScene(string sceneName)
    {
        if (Charector != null)
        {
            if (!Charector.isLockedCharector)
            {
                PlayerPrefs.SetInt("ChSelect",Charector.currentcountcharector);
                SceneManager.LoadScene(sceneName);
            }
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }


    public void ExitGame()
    {
#if UNITY_EDITOR
        
        UnityEditor.EditorApplication.isPlaying = false;

#endif
        Application.Quit();
    }
}
