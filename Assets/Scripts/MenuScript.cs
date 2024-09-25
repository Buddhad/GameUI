using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]GameObject quitDialog;
    //[SerializeField]GameObject audioMenu;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void UITESTPlayGame()
    {
        SceneManager.LoadScene("UITEST");
    }

    public void QuitGame()
    {
        quitDialog.SetActive(true);
    }

    public void LevelScene()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void YesExit()
    {
        Application.Quit();
    }
    public void NoExit()
    {
        
        quitDialog.SetActive(false);
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void UITESTHome()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void AudioMenu()
    {
        //audioMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
