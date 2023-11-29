using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] songs;  // Array of audio clips representing songs
    private AudioSource audioSource;
    private int currentSongIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySong(currentSongIndex);
    }

    void Update()
    {
        // Check if the current song has finished playing
        if (!audioSource.isPlaying)
        {
            // Move to the next song index
            currentSongIndex = (currentSongIndex + 1) % songs.Length;

            // Play the next song
            PlaySong(currentSongIndex);
        }
    }

    void PlaySong(int index)
    {
        // Stop the current song
        audioSource.Stop();

        // Set the new audio clip
        audioSource.clip = songs?[index];

        // Play the new song
        audioSource.Play();
    }
}
