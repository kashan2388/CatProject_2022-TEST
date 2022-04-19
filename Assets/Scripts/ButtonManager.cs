using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    GameObject Player;
    MainPlayer mainplayer;

    //==================================================
    public Slider skillgage;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        mainplayer = Player.GetComponent<MainPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�÷��̾� �̵�
    public void LeftMoveDown_Btn()
    {
        mainplayer.LeftMove = true;
    }
    public void LeftMoveUp_Btn()
    {
        mainplayer.LeftMove = false;

    }
    public void RightMoveDown_Btn()
    {
        mainplayer.RightMove = true;

    }
    public void RightMoveUp_Btn()
    {
        mainplayer.RightMove = false;
    }

    //�÷��̾� ��ų
    public void PSkill_Punch_Btn_() //damage: 20 , cost : 2
    {
        if(skillgage.value>=2)
        {
            mainplayer.PlayerSkill(0);
            skillgage.value -= 2;
        }
    }
    public void PSkill__Relax_Btn() //Recover: 30, cost : 4
    {
        if(skillgage.value>=4)
        {
            mainplayer.PlayerSkill(1);
            skillgage.value -= 4;
        }
        
    }
    public void PSkill_Mawind_Btn() //damage: 200, cost: 20
    {
        if(skillgage.value>=20)
        {
            mainplayer.PlayerSkill(2);
            skillgage.value -= 20;
        }
    }

}
