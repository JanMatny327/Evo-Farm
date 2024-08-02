using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    FarmSystem farmSystem;
    SellButton sellButton;


    private void Awake()
    {
        farmSystem = GetComponent<FarmSystem>();
        sellButton = GetComponent<SellButton>();
    }
    public void SellCrops()
    {
        switch(sellButton.ButtonName)
        {
            case "Bambo": break;
        }
    }
}
