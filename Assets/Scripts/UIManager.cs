using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider skillgage;
    public Slider summongage;

    MainPlayer mainplayer;
    ButtonManager buttonManager;

    [SerializeField]
    float fskillgageTime;
    // Start is called before the first frame update
    void Start()
    {
        skillgage.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Skillgage();
    }

    private void Skillgage()
    {
        if (skillgage.value <= skillgage.maxValue)
        {
            skillgage.value += Time.deltaTime;
        }
        else
        {
            Debug.Log("Full Gage");
        }
    }

    
}
