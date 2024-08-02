using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text FatigueText;
    public TMP_Text GoldText;

    private void Update()
    {
        GoldText.text = "������ : " + GameManager.Instance.gameData.gold;
        FatigueText.text = "�Ƿε� : " + GameManager.Instance.gameData.Fatigue;
    }
}
