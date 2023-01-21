using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    GameObject camera;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("CityRun", LoadSceneMode.Additive);
        camera = GameObject.FindWithTag("MainCamera");
        foreach (GameObject g in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            if(camera != g)
            {
                g.SetActive(false);
            }
        }

    }
}