using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("플레이어 상태")]
    [SerializeField] private float playerSpeed = 5.0f;
    [SerializeField] private int playerFatigue;

    [Header("플레이어 컴포넌트")]
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] private BoxCollider2D box2D;

    [Header("TalkSystem")]
    public TalkManager talkManager; // 대화창 클래스
    GameObject scanObject; // 내가 보고 있는 NPC 또는 사물
    Vector2 dirVec; // 내가 보고 있는 방향

   
    private void Update()
    {
        // GameManager.Instance.gameData.Fatigue = playerFatigue; 이거 비어있다고 오류남 나중에 고치셈 ㅇㅇ

        PlayerMove();
        // PlayerDrained();
        rayObject();
        playerTalk();
    }

    private void PlayerMove()
    {
        if(this.talkManager.isAction == true)
        {
            return;
        }
        else
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            transform.Translate(horizontal * playerSpeed * Time.deltaTime, vertical * playerSpeed * Time.deltaTime, 0f);
        }
        
    }

    private void PlayerDrained()
    {
        if (GameManager.Instance.gameData.Fatigue > 100) { playerSpeed = 0; }
    }

    void rayObject()
    {
        if (talkManager.isAction == true)
        {
            return;
        }
        else
        {
            if (Input.GetAxis("Horizontal") >    0)
            {
                dirVec = Vector2.right;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                dirVec = Vector2.left;
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                dirVec = Vector2.up;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                dirVec = Vector2.down;
            }
            Debug.DrawRay(rig2D.position, dirVec * 0.7f, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(rig2D.position, dirVec, 0.7f, LayerMask.GetMask("Object"));

            if (rayHit.collider != null)
            {
                scanObject = rayHit.collider.gameObject;
            }
            else
            {
                scanObject = null;
            }
        }
    }
    void playerTalk()
    {
        if (Input.GetKeyDown(KeyCode.F) && scanObject != null)
        {
            talkManager.Action(scanObject);
        }
    }
}

