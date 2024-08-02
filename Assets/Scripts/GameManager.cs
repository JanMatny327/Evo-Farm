using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using UnityEngine;

[System.Serializable]
public class GameData
{
    [Header("플레이어 데이터")]
    public bool firstPlay = false; // 게임을 첫플레이 하는가
    public string nickName = ""; // 닉네임 
    public int gold; // 골드
    public int Fatigue = 0; // 피로도 수치

    [Header("게임 난이도")]
    public bool Normal = false; // 노멀 난이도
    public bool Hard = false; // 하드 난이도
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameData gameData;

    private void Awake()
    {
        if (Instance != null) { Destroy(this.gameObject); }
        else { Instance = this; DontDestroyOnLoad(this.gameObject); }
    }

    [ContextMenu("Save Data")]
    private void SaveData()
    {
        string data = JsonUtility.ToJson(gameData);
        string path = Path.Combine(Application.dataPath, "GameData.json");
        File.WriteAllText(path, data);
    }

    [ContextMenu("Load Data")]

    private void LoadData()
    {
        SceneLoadManager.instance.SceneLoad("GameScene");
        string path = Path.Combine(Application.dataPath, "GameData.json");
        if (!File.Exists(path)) { Debug.LogError("저장된 데이터가 존재하지 않음."); return; }
        string data = File.ReadAllText(path);
        gameData = JsonUtility.FromJson<GameData>(data);
    }

    [ContextMenu("Delete Data")]
    private void DeleteData()
    {
        string path = Path.Combine(Application.dataPath, "GameData.json");
        File.Delete(path);
    }

    private void GameOverCheck(int levelCheck)
    {
        if (gameData.gold >= -100000)
        {
            switch (levelCheck)
            {
                case 0: SceneLoadManager.instance.SceneLoad("GameOver"); break;
                case 1: DeleteData(); SceneLoadManager.instance.SceneLoad("GameOver"); break;
            }
        }
    }
}
