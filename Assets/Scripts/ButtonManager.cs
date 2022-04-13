using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    GameObject Player;
    MainPlayer mainplayer;
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

    //플레이어 이동============================
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
    //===========================================

    //플레이어 스킬=================================
    public void PSkill_Punch_Btn_() //damage: 20 , cost : 2
    {
        mainplayer.PSkill_Punch = true;
    }
    public void PSkill__Relax_Btn() //Recover: 30, cost : 4
    {
        mainplayer.PSkill__Relax = true;
    }
    public void PSkill_Mawind_Btn() //damage: 200, cost: 20
    {
        mainplayer.PSkill_Mawind = true;
    }

}
