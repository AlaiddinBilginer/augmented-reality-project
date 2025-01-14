using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    private AudioSource musicSource; // Audio Source'yi tespit edeceðiz.
    private Button toggleButton; // Butonu tespit edeceðiz.
    private bool isMusicPlaying = true; // Baþlangýçta müzik çalýyor.

    void Start()
    {
        // "Audio Source" adlý objeyi bul ve AudioSource bileþenini al.
        musicSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();

        // "Sound off/open" adlý objeyi bul ve Button bileþenini al.
        toggleButton = GameObject.Find("Sound off/open").GetComponent<Button>();

        // Butonun týklama olayýný baðla.
        toggleButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isMusicPlaying)
        {
            musicSource.Pause(); // Müzik durdur.
        }
        else
        {
            musicSource.Play(); // Müzik baþlat.
        }

        isMusicPlaying = !isMusicPlaying; // Durumu deðiþtir.
    }
}
