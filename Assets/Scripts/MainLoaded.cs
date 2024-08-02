using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TMPro;
using Unity.Loading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLoaded : MonoBehaviour
{
    [SerializeField] private TMP_Text BroadText;
    [SerializeField] private Color StartColor;
    [SerializeField] private Color EndColor;
    private bool Message = false;
    [SerializeField] private bool First = true;
    [SerializeField] private bool First2 = false;
    [SerializeField] private bool First3 = false;
    [SerializeField] private bool Loading = false;

    private void Awake()
    {
        SoundManager.instance.PlayBgm("MainScene BGM");
    }
    private void Update()
    {
        StartCoroutine(MessageSay());
        StartCoroutine(MessageFade());
        BroadText.color = StartColor;

        if (Loading)
        {
            SceneLoadManager.instance.SceneLoad("TitleScene");
        }
    }

    IEnumerator MessageSay()
    {
        while (First)
        {
            StartColor.a += 0.5f * Time.deltaTime;
            BroadText.text = "�� ������ ����Ʈ���� ������ ���ߵǾ����ϴ�.";
            Message = true;
            yield return new WaitForSeconds(3.5f);
            First2 = true;
            First = false;
        }

        while (First2)
        {
            StartColor.a += 0.5f * Time.deltaTime;
            BroadText.text = "���� : �ϰ��̵�";
            Message = true;
            yield return new WaitForSeconds(4.5f);
            First3 = true;
            First2 = false;
        }

        while (First3)
        {
            StartColor.a += 0.5f * Time.deltaTime;
            BroadText.text = "Evo Farm";
            Message = true;
            yield return new WaitForSeconds(6.5f);
            First3 = false;
            Loading = true;
        }
    }

    IEnumerator MessageFade()
    {
        while (Message)
        {
            yield return new WaitForSeconds(1f);
            StartColor.a -= 0.5f * Time.deltaTime;

            if (StartColor.a <= 0f)
            {
                Message = false;
            }
        }
    }
}
