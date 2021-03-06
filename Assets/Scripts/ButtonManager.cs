using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    GameObject Player;
    MainPlayer mainplayer;

    [SerializeField] private Slider skillgage;
    void Start()
    {
        Player = GameObject.Find("Player");
        mainplayer = Player.GetComponent<MainPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //플레이어 이동
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

    //플레이어 스킬
    public void PSkill_Punch_Btn_() 
    {
        if (skillgage.value >= 2)
        {
            mainplayer.PlayerSkill(0);
            skillgage.value -= 2;
        }
    }
    public void PSkill__Relax_Btn() 
    {
        if (skillgage.value >= 4)
        {
            mainplayer.PlayerSkill(1);
            skillgage.value -= 4;
        }
    }
    public void PSkill_Mawind_Btn() 
    {
        if (skillgage.value >= 20)
        {
            mainplayer.PlayerSkill(2);
            skillgage.value -= 20;
        }
    }

}
