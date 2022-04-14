
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
        //�÷��̾� ��ġ �ʱ�ȭ
        //�÷��̾� HP �ʱ�ȭ
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //Vector2 position = transform.position;
        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //transform.position = position;

        //�̵� ����====
        PlayerMove();
        //=============

        //��ų ����=====
        PlayerSkill();

    }

    private void PlayerMove()
    {
        float movex = 0f;

        if (LeftMove)
        {
            Debug.Log("����");
            movex -= 0.1f;
        }
        if (RightMove)
        {
            Debug.Log("������");
            movex += 0.1f;
        }

        transform.Translate(new Vector2(movex, 0f) * Player_speed);
    }

    private void PlayerSkill()
    {
       
        if (PSkill_Punch)
        {
            Debug.Log("��ġ");
            uiManager.skillgage.value -= 2;
        }

        if (PSkill__Relax)
        {
            Debug.Log("����!");
            uiManager.skillgage.value -= 4;
        } 
        if (PSkill_Mawind)
        {
            Debug.Log("��ǳ!");
            uiManager.skillgage.value -= 20;
        }
    }
   


}
