using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip; // Здесь указывается аудиофайл для воспроизведения
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Если у игрового объекта нет AudioSource, добавьте его
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Установите аудиофайл для AudioSource
        audioSource.clip = audioClip;
    }

    private void OnMouseDown()
    {
        // Воспроизведите музыку при щелчке на объекте с коллайдером
        audioSource.Play();
    }
}
