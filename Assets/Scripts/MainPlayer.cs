using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;


    public float Player_Hp; //플레이어 Hp - UI 와 연계 

    [SerializeField] private int SkillDmg; //공격 데미지
    [SerializeField] private float atkSpeed = 1; //공격속도(애니 속도도 같이 변경) 
    [SerializeField] private bool attacked = false; //공격 상태 유무
    [SerializeField] private float Accuracy; // 명중률
    [SerializeField] private float Player_speed; //플레이어 속도

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

        //플레이어 이동
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
            Debug.Log("왼쪽");
            movex -= 0.1f;
        }
        if (RightMove)
        {
            Debug.Log("오른쪽");
            movex += 0.1f;

        }

        transform.Translate(new Vector2(movex, 0f) * Player_speed);
    } //플레이어 이동

    public void TakeDamage(float dmg)
    {
        Player_Hp = Player_Hp - dmg;
        if (Player_Hp <= 0)
        {
            Player_Hp = 0;
            PlayerDie();
        }
    } //플레이어 피격

    private void PlayerDie()
    {
        isPlayer_dead = true;
    } //플레이어 죽음
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
    } //플레이어 스킬 선언


    private void SKillPunch() // 플레이어 스킬 펀치 |damage: 20 , cost : 2
    {
        Debug.Log("펀치 활성화");
    }
    private void SKillHeal() //플레이엉 스킬 힐 |Recover: 30, cost : 4
    {
        Debug.Log("힐링!");
    }
    private void SKillWind() //플레이어 스킬 마풍(궁) |damage: 200, cost: 20
    {
        Debug.Log("마풍!");
    }
}