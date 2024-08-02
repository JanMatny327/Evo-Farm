using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class FarmSystem : MonoBehaviour
{
    [Header("농작물 성작 관리")]
    [SerializeField] private int growthTime; // 성장하는데 걸리는 시간 관리 변수(integer)
    [SerializeField] public bool growthComplete = false; // 성장이 다 됬는지 확인하는 변수(boolen)

    [Header("농작물 게임 오브젝트")]
    [SerializeField] private GameObject[] cropsObject;
    [SerializeField] private GameObject[] cropsObjectPrefabs;

    [Header("농작물 성장 이미지")]
    [SerializeField] private SpriteRenderer[] cropsSprite;

    [Header("농작물 종류")]
    public string cropsTypeEx = " ----- 작물 종류 소개 ----- " +
        "\nBambo : 대나무" +
        "\nWeed : 잡초" +
        "\nPotato : 감자" +
        "\nRose : 장미 " +
        "\nCistus : 시스투스" +
        "\nSweetPotato : 고구마" +
        "\nWildGinseng : 산삼" +
        "\nCorner : 옥수수" +
        "\nApple : 사과" +
        "\nPeach : 복숭아";


    [SerializeField] private CropsType cropsType;
    private string curCrop;

    private void Update()
    { 
        CropsGrowthCheck();
    }

    
    public enum CropsType // 어떤 작물인지 확인할 수 있게 하는 구분자
    {
        Bambo, // 대나무
        Weed, // 잡초
        Potato, // 감자
        Rose, // 장미
        Cistus, // 시스투스
        SweetPotato, // 고구마
        WildGinseng, // 산삼
        Corner, // 옥수수
        Apple, // 사과
        Peach // 복숭아
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
