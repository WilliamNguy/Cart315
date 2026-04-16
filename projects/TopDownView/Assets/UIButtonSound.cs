using UnityEngine;

public class UIButtonSound : MonoBehaviour
{
    public AudioManager audioManager;

    public void PlayClickSound()
    {
        audioManager.PlayButtonClickSound();
    }
}