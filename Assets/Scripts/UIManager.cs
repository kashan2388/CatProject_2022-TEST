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
    float fskillgageTime;//��ų �ڽ�Ʈ ���� �ð�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SkillgageUI();
    }

    private void SkillgageUI()   //��ų ������ ���� , ��ư�Ŵ������� �ҷ��� 
    {   
        //1/3 �ʿ� 1�� �������� ��. 
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

    private void playerHpGage() //�÷��̾� Hp ������ 
    {

    }

    private void enemyTowerHpGage() //�� Ÿ�� ������ 
    {

    }

}
