using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using UnityEngine;

[System.Serializable]
public class GameData
{
    [Header("�÷��̾� ������")]
    public bool firstPlay = false; // ������ ù�÷��� �ϴ°�
    public string nickName = ""; // �г��� 
    public int gold; // ���
    public int Fatigue = 0; // �Ƿε� ��ġ

    [Header("���� ���̵�")]
    public bool Normal = false; // ��� ���̵�
    public bool Hard = false; // �ϵ� ���̵�
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
        if (!File.Exists(path)) { Debug.LogError("����� �����Ͱ� �������� ����."); return; }
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
