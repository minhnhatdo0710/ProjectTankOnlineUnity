using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{   public void BackHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }
    public void Construction()
    {
        SceneManager.LoadScene("Construction", LoadSceneMode.Single);
    }
    public void Exit() {
        Debug.Log("Exit game");
        Application.Quit();  
    } 
    
}
