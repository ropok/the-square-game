using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSourceMusic;
    public AudioSource audioSourceJump;
    public AudioSource audioSourceDie;

    private void Start()
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        audioSourceMusic.Play();
    }

    public void PlayJump()
    {
        audioSourceJump.Play();
    }

    public void PlayDie()
    {
        audioSourceDie.Play();
    }
}
