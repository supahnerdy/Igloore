using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject aboutPage;
    // Start is called before the first frame update
    void Start()
    {
        titleScreen.SetActive(true);
        aboutPage.SetActive(false);
        Cursor.visible = true;
    }
    public void PlayGame() // upon hitting the play button: ~TW
    {
        SceneManager.LoadScene("LevelScene"); // load the first level. ~TW
        Time.timeScale = 1f; // make sure time is unfrozen incase it was before. ~TW
    }
    public void AboutPage() // switch to about ~TW
    {
        titleScreen.SetActive(false);
        aboutPage.SetActive(true);
    }
    public void BackToMain() // switch to main ~TW
    {
        aboutPage.SetActive(false);
        titleScreen.SetActive(true);
    }
}


