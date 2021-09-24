using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainStage");
    }

    public void PlayAgain()
    {
        //SceneManager.UnloadSceneAsync("MainStage");
        SceneManager.LoadScene("MainStage");
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Title");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
