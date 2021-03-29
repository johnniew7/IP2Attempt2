using UnityEngine;
using UnityEngine.SceneManagement;

class LevelSelect : MonoBehaviour
{
    
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
