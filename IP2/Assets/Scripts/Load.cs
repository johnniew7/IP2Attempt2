using UnityEngine;
using UnityEngine.SceneManagement;
class Load : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}