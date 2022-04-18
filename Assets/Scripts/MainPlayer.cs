using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;

    public float Player_Hp; //플레이어 Hp - UI 와 연계 
    public int SkillDmg; //공격 데미지
    public float atkSpeed = 1; //공격속도
    public bool attacked = false; //공격 상태 유무
    public float Accuracy; // 명중률
    public float Player_speed; //플레이어 속도

    

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

        //플레이어 이동
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



    //플레이어 스킬 
    private void SKillPunch()
    {
        Debug.Log("펀치 활성화");
    }
    private void SKillHeal()
    {
        Debug.Log("힐링!");
    }
    private void SKillWind()
    {
        Debug.Log("마풍!");
    }
}

