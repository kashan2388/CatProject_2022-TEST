using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayer : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;

    public Image nowHpbar;

    public float Player_Hp; //�÷��̾� Hp - UI �� ���� 

    public float SkillDmg; //���� ������
    [SerializeField] private float atkSpeed = 1; //���ݼӵ�(�ִ� �ӵ��� ���� ����) 
    public bool attacked = false; //���� ���� ����
    [SerializeField] private float Accuracy; // ���߷�
    [SerializeField] private float Player_speed; //�÷��̾� �ӵ�

    public bool isPlayer_dead = false;

    //========================================
    SpriteRenderer spriteRenderer;

    private Rigidbody2D playerRigid;

    //===========================================
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
        ;

    }

    private void FixedUpdate()
    {
        PlayerMove();
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
    } //�÷��̾� �̵�

    public void TakeDamage(float dmg)
    { 
        Player_Hp = Player_Hp - dmg;
        if (Player_Hp <= 0)
        {
            Player_Hp = 0;
            PlayerDie();
        }
    } //�÷��̾� �ǰ�
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "Enemy")
    //    {
            
    //    }
    //}
    private void PlayerDie()
    {
        isPlayer_dead = true;
    } //�÷��̾� ����
    public void PlayerSkill(int i)
    {
        switch (i)
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
    } //�÷��̾� ��ų ����


    private void SKillPunch() // �÷��̾� ��ų ��ġ |damage: 20 , cost : 2
    {
        attacked = true;
        Debug.Log("��ġ Ȱ��ȭ");
    }
    private void SKillHeal() //�÷��̾� ��ų �� |Recover: 30, cost : 4
    {
        attacked = true;
        Debug.Log("����!");
    }
    private void SKillWind() //�÷��̾� ��ų ��ǳ(��) |damage: 200, cost: 20
    {
        attacked = true;
        Debug.Log("��ǳ!");
    }
}