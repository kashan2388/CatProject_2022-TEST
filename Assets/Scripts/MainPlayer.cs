using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;

    public float Player_Hp; //�÷��̾� Hp - UI �� ���� 
    public int SkillDmg; //���� ������
    public float atkSpeed = 1; //���ݼӵ�
    public bool attacked = false; //���� ���� ����
    public float Accuracy; // ���߷�
    public float Player_speed; //�÷��̾� �ӵ�

    

    SpriteRenderer spriteRenderer;

    private Rigidbody2D playerRigid;

    
    

    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //Vector2 position = transform.position;
        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //transform.position = position;

        //�÷��̾� �̵�
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

    public void PlayerSkill(int i)
    {
        switch(i)
        {
            case 0:
                SKillPunch();
                break;

            case 1:
                SKillHeal();
                break;

            case 2:
                SKillWind();
                break;
        }
    }



    //�÷��̾� ��ų 
    private void SKillPunch()
    {
        Debug.Log("��ġ Ȱ��ȭ");
    }
    private void SKillHeal()
    {
        Debug.Log("����!");
    }
    private void SKillWind()
    {
        Debug.Log("��ǳ!");
    }
}

