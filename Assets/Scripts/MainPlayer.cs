using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
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

        //플레이어 스킬
        if (PSkill_Punch)
        {
            Debug.Log("펀치 활성화");
        }

        if (PSkill__Relax)
        {
            Debug.Log("힐링!");
        }
        if (PSkill_Mawind)
        {
            Debug.Log("마풍!");

        }
    }
}