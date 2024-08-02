using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    public static SceneLoadManager instance;

    private void Awake()
    {
        if (instance != null) Destroy(this.gameObject);
        else { instance = this; DontDestroyOnLoad(this.gameObject); }
    }

    public void SceneLoad(string type)
    {
        switch(type)
        {
            case "TitleScene": SceneManager.LoadScene("TitleScene"); SoundManager.instance.PlayBgm("TitleScene BGM"); break;
            case "GameScene": SceneManager.LoadScene("GameScene"); SoundManager.instance.PlayBgm("GameScene BGM"); break;
            case "GameOverScene": SceneManager.LoadScene("GameOver"); SoundManager.instance.PlayBgm("GameOver BGM"); break;
                //case "GameClearScene": SceneManager.LoadScene("GameClear"); SoundManager.instance.PlayBgm("GameClear BGM"); break;
        }
    }
}
