using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textTitle;
    [SerializeField] private TextMeshProUGUI textScore;
    [SerializeField] private TextMeshProUGUI textHighscore;
    [SerializeField] private Button buttonPlay;
    [SerializeField] private Button buttonMusic;
    [SerializeField] private Button buttonSound;
    [SerializeField] private bool isMusic;
    [SerializeField] private bool isAudio;
    [SerializeField] MusicManager musicManager;

    public void ChangeMenu(bool x)
    {
        textTitle.gameObject.SetActive(x);
        textScore.gameObject.SetActive(!x);
        textHighscore.gameObject.SetActive(!x);
        buttonPlay.gameObject.SetActive(x);
        buttonMusic.gameObject.SetActive(x);
        buttonSound.gameObject.SetActive(x);
    }

    public void ChangeAudio()
    {
        isAudio = !isAudio;
        musicManager.audioSourceDie.mute = isAudio;
        musicManager.audioSourceJump.mute = isAudio;
    }

    public void ChangeMusic()
    {
        isMusic = !isMusic;
        musicManager.audioSourceMusic.mute = isMusic;
    }
}
