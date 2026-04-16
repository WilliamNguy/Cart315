using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioSource musicSource;
    public AudioSource ambientSource;

    public AudioClip pickupSound;
    public AudioClip deliverySound;
    public AudioClip gameOverSound;
    public AudioClip buttonClickSound;
    public AudioClip backgroundMusic;
    public AudioClip gameplayAmbientLoop;

    void Start()
    {
        if (backgroundMusic != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    public void PlayPickupSound()
    {
        sfxSource.PlayOneShot(pickupSound);
    }

    public void PlayDeliverySound()
    {
        sfxSource.PlayOneShot(deliverySound);
    }

    public void PlayGameOverSound()
    {
        sfxSource.PlayOneShot(gameOverSound);
    }

    public void PlayButtonClickSound()
    {
        sfxSource.PlayOneShot(buttonClickSound);
    }

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void StartAmbientLoop()
    {
        if (gameplayAmbientLoop != null && !ambientSource.isPlaying)
        {
            ambientSource.clip = gameplayAmbientLoop;
            ambientSource.loop = true;
            ambientSource.Play();
        }
    }

    public void StopAmbientLoop()
    {
        ambientSource.Stop();
    }
}