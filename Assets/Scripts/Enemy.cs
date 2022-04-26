using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour //������ �������� ���� 
{
   
    public float height = 1.7f;
    public bool CanMove = true;
    public Animator EnemyAnimator;
    [SerializeField] string enemy_Name;
    [SerializeField] private float enemy_maxHp;
    [SerializeField] private float enemy_nowHp;
    [SerializeField] private float enemy_moveSpeed;
    [SerializeField] private int enemy_atkDmg;
    [SerializeField] private int enemy_atkSpeed;
    [SerializeField] private float enemy_atkDuration; //���� ���� �ð� 

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
    private void Awake()
    {
        EnemyAnimator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (CanMove == true)
        {
            EnemyMove();
        }
    }

    void EnemyHpBar()
    {
        //���࿡ �÷��̾ ������ ���� ������ true�϶�
        //enemyHpbar�� ��ġ�� �����ִ� ������ ��ġ�� ��� ��� �� + y �� ��ǥ(+) �� �����Ѵ�

    }
    void EnemyMove()
    {
        transform.Translate(Vector2.left * Time.deltaTime * enemy_moveSpeed);

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("AL01"))
        {
            CanMove = false;
            EnemyAnimator.SetTrigger("Attack");
            InvokeRepeating("nowhp", 1f, 1f);
        }
    }

    public void nowhp()
    {
        enemy_nowHp -= 7;
    }
}
