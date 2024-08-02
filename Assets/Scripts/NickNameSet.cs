using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NickNameSet : MonoBehaviour
{
    [SerializeField] private TMP_InputField nickNameField;
    [SerializeField] private TMP_Text curNicknameText;
    [SerializeField] private TMP_Text curNickNameText2;
    [SerializeField] private string nickName;
    [SerializeField] private GameObject SelectPanel;

    private void Awake()
    {
        nickNameField.characterLimit = 8;
    }

    private void Update()
    {

    }

    public void OnNickNameValueChanged()
    {
        curNicknameText.text = "현재 닉네임 : " + nickNameField.text;
        curNickNameText2.text = "현재 닉네임 : " + nickNameField.text;
        nickName = nickNameField.text;
    }

    public void SelectNickName()
    {
        SelectPanel.SetActive(true);
    }

    public void Select()
    {
        GameManager.Instance.gameData.nickName = nickName;
        SceneLoadManager.instance.SceneLoad("GameScene");
    }

    public void Cancel()
    {
        SelectPanel.SetActive(false);
    }
}
