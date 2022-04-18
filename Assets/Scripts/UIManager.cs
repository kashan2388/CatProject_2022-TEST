using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider skillgage; 

    MainPlayer mainPlayer;
    ButtonManager buttonManager;

    [SerializeField]
    float fskillgageTime; //스킬코스트 차는 시간

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skillgage.value < skillgage.maxValue)
        {
            skillgage.value += Time.deltaTime/ fskillgageTime;
        }
        else
        {
            Debug.Log("Full Gage");
        }
    }
}
