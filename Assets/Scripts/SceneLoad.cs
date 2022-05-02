using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadBattle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Battle");
    }
    public void LoadMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}
