using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [Header("BGM 관리")]
    [SerializeField] private AudioClip[] BGMClips;
    [SerializeField] private AudioSource bgmPlayer;

    [Header("SFX 관리")]
    [SerializeField] private AudioClip[] SFXClips;
    [SerializeField] private AudioSource sfxPlayer;

    //[Header("슬라이더 컴포넌트")]
    //[SerializeField] private Slider bgmSlider;
    //[SerializeField] private Slider sfxSlider;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void PlayBgm(string type)
    {
        int index = 0;

        switch(type)
        {
            case "MainScene BGM": index = 0; break;
            case "TitleScene BGM": index = 0; break;
            case "GameScene BGM": index = 1; break;
            case "GameOver BGM": index = 2; break;
        }

        bgmPlayer.clip = BGMClips[index];
        bgmPlayer.Play();
    }

    public void PlaySFX(string type)
    {
        int index = 0;

        switch(type)
        {
            case "Shop Open": index = 0; break;
            case "Quest Clear": index = 1; break;
        }

        sfxPlayer.clip = SFXClips[index];
        sfxPlayer.PlayOneShot(sfxPlayer.clip);
    }
    private void ChangeBgmSound(float value)
    {
        bgmPlayer.volume = value;
    }

    private void ChangeSfxSound(float value)
    {
        sfxPlayer.volume = value;
    }
}
