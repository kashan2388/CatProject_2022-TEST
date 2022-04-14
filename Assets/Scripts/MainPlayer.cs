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

        //�÷��̾� ��ų
        if (PSkill_Punch)
        {
            Debug.Log("��ġ Ȱ��ȭ");
        }

        if (PSkill__Relax)
        {
            Debug.Log("����!");
        }
        if (PSkill_Mawind)
        {
            Debug.Log("��ǳ!");

        }
    }
}