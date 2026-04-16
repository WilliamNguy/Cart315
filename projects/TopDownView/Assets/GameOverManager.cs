using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
public AudioManager audioManager;

    public GameObject gameOverPanel;

    private bool gameIsOver = false;

    public void GameOver()
    {
        if (gameIsOver) return;

        gameIsOver = true;
        gameOverPanel.SetActive(true);
audioManager.PlayGameOverSound();
audioManager.StopAmbientLoop();
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}