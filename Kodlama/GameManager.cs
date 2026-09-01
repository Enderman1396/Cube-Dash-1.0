using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool oyunBitti = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        Debug.Log("Oyunun Sonuna Geldiniz!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (oyunBitti == false)
        {
        Debug.Log("Oyun Bitti");
        oyunBitti = true;
        Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
