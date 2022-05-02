using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float PlayLimitTime;
    public Text text_Timer;

    void Update()
    {
        PlayLimitTime -= Time.deltaTime;
        text_Timer.text = "남은 시간 :" + Mathf.Round(PlayLimitTime);
    }
}
