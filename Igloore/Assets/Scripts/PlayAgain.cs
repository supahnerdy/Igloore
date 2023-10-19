using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f; // freeze the game over screen. ~TW
    }
    public void BackToTitle() // load title screen when hitting play again button. ~TW
    {
        SceneManager.LoadScene("TitleScreen");
        Time.timeScale = 1f;
    }
}
