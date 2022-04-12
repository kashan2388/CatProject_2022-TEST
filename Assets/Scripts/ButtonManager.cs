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

}
