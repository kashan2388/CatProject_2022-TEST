using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
 
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
           if (GameIsPaused){
                Resume();
            }
            else{
                Pause1();
            }
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause1()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Run()
    {
        Debug.Log("아직 미구현입니다...");
        //Time.timeScale = 1f; //SceneManager.LoadScene("MainMenu");
    }

   
}
