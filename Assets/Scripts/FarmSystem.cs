using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class FarmSystem : MonoBehaviour
{
    [Header("농작물 성작 관리")]
    [SerializeField] private int growthTime; // 성장하는데 걸리는 시간 관리 변수(integer)
    [SerializeField] private bool growthComplete = false; // 성장이 다 됬는지 확인하는 변수(boolen)

    [Header("농작물 게임 오브젝트")]
    [SerializeField] private GameObject[] cropsObject;

    [Header("농작물 성장 이미지")]
    [SerializeField] private SpriteRenderer[] cropsSprite;

    [Header("농작물 종류")]
    public string cropsTypeEx = " ----- 작물 종류 소개 ----- " +
        "\nMushroomSpores : 버섯 포자" +
        "\npotato : 감자" +
        "\nrice : 쌀" +
        "\nWeeds : 잡초 " +
        "\nWildginseng : 산삼" +
        "\nCistus : 시스투스" +
        "\nPeach : 복숭아" +
        "\nbambo : 대나무" +
        "\n" +
        "\n";

    [Header("농작물 구매/판매 가격")]
    [SerializeField] private int cropsSellGold;

    [SerializeField] private CropsType cropsType;
    private string curCrop;

    private void Update()
    { 
        CropsGrowthCheck();
    }

    
    public enum CropsType // 어떤 작물인지 확인할 수 있게 하는 구분자
    {
        Mandragora, // 만드라고라
        WorldTreeStick, // 세계수의 가지
        GoldApple, // 황금사과
        MushroomSpores, // 버섯 포자
        potato, // 감자
        rice, // 쌀
        FakeBulocho, // 불로초(짭)
        CandleofImmortality, // 진시황의 불로초
        OneThousandCPeach, // 1000도 복숭아
        Wildginseng, // 산삼
        AngelFlower // 천사의 꽃
    }
    private void CropsGrowthCheck()
    {
        switch(cropsType)
        {
            case CropsType.Mandragora: if (growthTime >= 0) { growthComplete = true; this.cropsSellGold = 7000; } break;
            case CropsType.WorldTreeStick: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.GoldApple: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.MushroomSpores: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.potato: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.rice: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.FakeBulocho: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.CandleofImmortality: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.OneThousandCPeach: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Wildginseng: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.AngelFlower: if (growthTime >= 0) { growthComplete = true; } break;
        }
    }

    private void CropsGrowthComplete()
    {

    }
}
