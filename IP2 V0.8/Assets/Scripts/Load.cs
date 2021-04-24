using UnityEngine;
using UnityEngine.SceneManagement;

class Load : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}