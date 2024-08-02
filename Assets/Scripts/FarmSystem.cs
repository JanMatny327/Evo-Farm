using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class FarmSystem : MonoBehaviour
{
    [Header("���۹� ���� ����")]
    [SerializeField] private int growthTime; // �����ϴµ� �ɸ��� �ð� ���� ����(integer)
    [SerializeField] private bool growthComplete = false; // ������ �� ����� Ȯ���ϴ� ����(boolen)

    [Header("���۹� ���� ������Ʈ")]
    [SerializeField] private GameObject[] cropsObject;

    [Header("���۹� ���� �̹���")]
    [SerializeField] private SpriteRenderer[] cropsSprite;

    [Header("���۹� ����")]
    public string cropsTypeEx = " ----- �۹� ���� �Ұ� ----- " +
        "\nMushroomSpores : ���� ����" +
        "\npotato : ����" +
        "\nrice : ��" +
        "\nWeeds : ���� " +
        "\nWildginseng : ���" +
        "\nCistus : �ý�����" +
        "\nPeach : ������" +
        "\nbambo : �볪��" +
        "\n" +
        "\n";

    [Header("���۹� ����/�Ǹ� ����")]
    [SerializeField] private int cropsSellGold;

    [SerializeField] private CropsType cropsType;
    private string curCrop;

    private void Update()
    { 
        CropsGrowthCheck();
    }

    
    public enum CropsType // � �۹����� Ȯ���� �� �ְ� �ϴ� ������
    {
        Mandragora, // �������
        WorldTreeStick, // ������� ����
        GoldApple, // Ȳ�ݻ��
        MushroomSpores, // ���� ����
        potato, // ����
        rice, // ��
        FakeBulocho, // �ҷ���(¬)
        CandleofImmortality, // ����Ȳ�� �ҷ���
        OneThousandCPeach, // 1000�� ������
        Wildginseng, // ���
        AngelFlower // õ���� ��
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
