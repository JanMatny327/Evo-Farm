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
        GoldText.text = "소지금 : " + GameManager.Instance.gameData.gold;
        FatigueText.text = "피로도 : " + GameManager.Instance.gameData.Fatigue;
    }
}
