
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;

    SpriteRenderer spriteRenderer;

    [SerializeField]
    private float Player_speed;
    private float Player_Hp;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //Vector2 position = transform.position;
        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //transform.position = position;

        if(LeftMove)
        {
            Debug.Log("����");
        }
        if(RightMove)
        {
            Debug.Log("������");

        }

    }

   


}
