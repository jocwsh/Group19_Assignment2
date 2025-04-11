using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject MainSettingsUI;

    void Start()
    {
        MainSettingsUI.SetActive(false);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMainSettings()
    {
        MainSettingsUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void CloseMainSettings()
    {
        MainSettingsUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
