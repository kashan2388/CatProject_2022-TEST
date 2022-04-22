using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour //적에게 공통으로 들어가는 
{
   
    public float height = 1.7f;

    [SerializeField] string enemy_Name;
    [SerializeField] private float enemy_maxHp;
    [SerializeField] private float enemy_nowHp;
    [SerializeField] private float enemy_moveSpeed;
    [SerializeField] private int enemy_atkDmg;
    [SerializeField] private int enemy_atkSpeed;
    [SerializeField] private float enemy_atkDuration; //공격 지속 시간 

    private void SetEnemyStatus(string _enemyName, int _maxHp, int _atkDmg, int _atkSpeed)
    {
        enemy_Name = _enemyName;
        enemy_maxHp = _maxHp;
        enemy_nowHp = _maxHp;
        enemy_atkDmg = _atkDmg;
        enemy_atkSpeed = _atkSpeed;

    }

    private void Start()
    {
       
    }
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        EnemyMove();
    }

    void EnemyHpBar()
    {
        //만약에 플레이어가 적에게 공격 당함이 true일때
        //enemyHpbar의 위치는 속해있는 프리팹 위치의 상단 가운데 위 + y 축 좌표(+) 로 결정한다

    }
    void EnemyMove()
    {
        transform.Translate(Vector2.left * Time.deltaTime * enemy_moveSpeed);

    }
}
