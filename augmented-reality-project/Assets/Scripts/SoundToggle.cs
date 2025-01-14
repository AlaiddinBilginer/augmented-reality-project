using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    private AudioSource musicSource; // Audio Source'yi tespit edece�iz.
    private Button toggleButton; // Butonu tespit edece�iz.
    private bool isMusicPlaying = true; // Ba�lang��ta m�zik �al�yor.

    void Start()
    {
        // "Audio Source" adl� objeyi bul ve AudioSource bile�enini al.
        musicSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();

        // "Sound off/open" adl� objeyi bul ve Button bile�enini al.
        toggleButton = GameObject.Find("Sound off/open").GetComponent<Button>();

        // Butonun t�klama olay�n� ba�la.
        toggleButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isMusicPlaying)
        {
            musicSource.Pause(); // M�zik durdur.
        }
        else
        {
            musicSource.Play(); // M�zik ba�lat.
        }

        isMusicPlaying = !isMusicPlaying; // Durumu de�i�tir.
    }
}
