using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider skillgage;
    [SerializeField] private Slider playerHpgage;
    [SerializeField] private Slider enemyHpgage;
    [SerializeField] private Slider EnemyTowerHpgage;

    MainPlayer mainPlayer;
    ButtonManager buttonManager;

    [SerializeField]
    float fskillgageTime;//스킬 코스트 차는 시간

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SkillgageUI();
    }

    private void SkillgageUI()   //스킬 게이지 관련 , 버튼매니저에서 불러옴 
    {   
        //1/3 초에 1씩 게이지가 참. 
        if (skillgage.value < skillgage.maxValue)
        {
            skillgage.value += Time.deltaTime / fskillgageTime;
        }
        else
        {
            Debug.Log("Full Gage");
        }
        if (skillgage.value < 0)
        {
            skillgage.value = 0;
        }
    }

    private void playerHpGage() //플레이어 Hp 게이지 
    {

    }

    private void enemyTowerHpGage() //적 타워 게이지 
    {

    }

}
