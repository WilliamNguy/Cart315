using UnityEngine;

public class StartMenuManager : MonoBehaviour
{
    public GameObject startPanel;
    public AudioManager audioManager;

    void Start()
    {
        startPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        audioManager.SetMusicVolume(0.1f);
        startPanel.SetActive(false);
audioManager.StartAmbientLoop();
        Time.timeScale = 1f;
    }
}