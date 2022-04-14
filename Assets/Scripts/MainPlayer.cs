
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public UIManager uiManager;

    public bool LeftMove = false;
    public bool RightMove = false;
    public bool PSkill_Punch = false;
    public bool PSkill__Relax = false;
    public bool PSkill_Mawind = false;

    SpriteRenderer spriteRenderer;

    private Rigidbody2D playerRigid;

    [SerializeField]
    private float Player_speed;
    private float Player_Hp;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
        //플레이어 위치 초기화
        //플레이어 HP 초기화
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //Vector2 position = transform.position;
        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //transform.position = position;

        //이동 관련====
        PlayerMove();
        //=============

        //스킬 관련=====
        PlayerSkill();

    }

    private void PlayerMove()
    {
        float movex = 0f;

        if (LeftMove)
        {
            Debug.Log("왼쪽");
            movex -= 0.1f;
        }
        if (RightMove)
        {
            Debug.Log("오른쪽");
            movex += 0.1f;
        }

        transform.Translate(new Vector2(movex, 0f) * Player_speed);
    }

    private void PlayerSkill()
    {
       
        if (PSkill_Punch)
        {
            Debug.Log("펀치");
            uiManager.skillgage.value -= 2;
        }

        if (PSkill__Relax)
        {
            Debug.Log("힐링!");
            uiManager.skillgage.value -= 4;
        } 
        if (PSkill_Mawind)
        {
            Debug.Log("마풍!");
            uiManager.skillgage.value -= 20;
        }
    }
   


}
