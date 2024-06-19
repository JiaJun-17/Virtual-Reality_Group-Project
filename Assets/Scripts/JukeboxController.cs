using UnityEngine;

public class JukeboxController : MonoBehaviour
{
    public AudioSource[] audioSources;
    private int currentTrack = 0;

    void Start()
    {
        if (audioSources.Length > 0)
        {
            PlayTrack(currentTrack);
        }
    }

    void Update()
    {
           if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKeyDown(KeyCode.P)) // Press Shift + 'P' to change tracks
            {
                NextTrack();
            }
        }
    }

    void PlayTrack(int index)
    {
        StopAllTracks();
        audioSources[index].Play();
    }

    void StopAllTracks()
    {
        foreach (AudioSource source in audioSources)
        {
            source.Stop();
        }
    }

    void NextTrack()
    {
        currentTrack = (currentTrack + 1) % audioSources.Length;
        PlayTrack(currentTrack);
    }

    void PreviousTrack()
    {
        currentTrack--;
        if (currentTrack < 0)
        {
            currentTrack = audioSources.Length - 1;
        }
        PlayTrack(currentTrack);
    }
}
