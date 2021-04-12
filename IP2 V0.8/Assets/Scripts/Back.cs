using UnityEngine;
using UnityEngine.SceneManagement;

class Back : MonoBehaviour
{
    public void GoBack()
    {
        Debug.Log("Gone Back");
        SceneManager.LoadScene("MainMenu");
    }
}
