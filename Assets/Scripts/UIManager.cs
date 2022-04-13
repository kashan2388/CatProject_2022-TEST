using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider skillgage;

    MainPlayer mainplayer;
    ButtonManager buttonManager;

    [SerializeField]
    float fskillgageTime;
    // Start is called before the first frame update
    void Start()
    {
        //skillgage = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(skillgage.value <skillgage.maxValue)
        {
            skillgage.value += Time.deltaTime;
        }
        else
        {
            Debug.Log("Full Gage");
        }
    }
}
