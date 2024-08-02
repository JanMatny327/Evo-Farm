using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class FarmSystem : MonoBehaviour
{
    [Header("���۹� ���� ����")]
    [SerializeField] private int growthTime; // �����ϴµ� �ɸ��� �ð� ���� ����(integer)
    [SerializeField] public bool growthComplete = false; // ������ �� ����� Ȯ���ϴ� ����(boolen)

    [Header("���۹� ���� ������Ʈ")]
    [SerializeField] private GameObject[] cropsObject;
    [SerializeField] private GameObject[] cropsObjectPrefabs;

    [Header("���۹� ���� �̹���")]
    [SerializeField] private SpriteRenderer[] cropsSprite;

    [Header("���۹� ����")]
    public string cropsTypeEx = " ----- �۹� ���� �Ұ� ----- " +
        "\nBambo : �볪��" +
        "\nWeed : ����" +
        "\nPotato : ����" +
        "\nRose : ��� " +
        "\nCistus : �ý�����" +
        "\nSweetPotato : ����" +
        "\nWildGinseng : ���" +
        "\nCorner : ������" +
        "\nApple : ���" +
        "\nPeach : ������";


    [SerializeField] private CropsType cropsType;
    private string curCrop;

    private void Update()
    { 
        CropsGrowthCheck();
    }

    
    public enum CropsType // � �۹����� Ȯ���� �� �ְ� �ϴ� ������
    {
        Bambo, // �볪��
        Weed, // ����
        Potato, // ����
        Rose, // ���
        Cistus, // �ý�����
        SweetPotato, // ����
        WildGinseng, // ���
        Corner, // ������
        Apple, // ���
        Peach // ������
    }
    private void CropsGrowthCheck()
    {
        switch(cropsType)
        {
            case CropsType.Bambo: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Weed: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Potato: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Rose: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Cistus: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.SweetPotato: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.WildGinseng: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Corner: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Apple: if (growthTime >= 0) { growthComplete = true; } break;
            case CropsType.Peach: if (growthTime >= 0) { growthComplete = true; } break;
        }
    }

    private void CropsHarvesting()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FarmZone"))
        {
            if (Input.GetKeyDown(KeyCode.R)) { Instantiate(this.cropsObject[0], collision.gameObject.transform.position, collision.transform.rotation); return; }
        }
    }
}
