using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager1 : MonoBehaviour
{
    public GameObject gameOverCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
