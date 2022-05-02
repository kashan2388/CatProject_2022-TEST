using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class EnemyState
{
    public int hp;
    public float state1;

}
public class Enemy : MonoBehaviour //������ �������� ���� 
{
    public EnemyState mystate1;


    [SerializeField] string enemy_Name; //�� �̸�

    public GameObject prfHpBar;
    public GameObject canvas;

    RectTransform hpBar;

    public float height = 2.5f;

    public float enemy_maxHp; // ��ü ü��
    public float enemy_nowHp; // ���� ü��
    public float enemy_moveSpeed; //�� �̵� �ӵ�
    public int enemy_atkDmg; // �� ���ݷ�
    [Tooltip("���� ���� �ð�(���� �� ������ ����)")]
    public float enemy_atkSpeed; //���� �ӵ�(������) 

    [SerializeField] float currentTime;
    //[Header("�ִϸ����� ����")]
    //public Animator M01_Animator;
    //public Animator M02_Animator;
    //public Animator M03_Animator;
    //[Header("BOSS �ִϸ�����")]
    //public Animator MB04_Animator;

    [Header("����")]
    public Transform atkBox;
    public LayerMask targetMask;
    public Transform target;

    public Animator EnemyAnimator;



    public bool CanMove = true;
    //public struct EnemyIdleState
    //{
    //}

    private void SetEnemyStatus(string _enemyName, float _maxHp, int _atkDmg,float _movespeed, float _atkDelay)
    {
        enemy_Name = _enemyName;
        enemy_maxHp = _maxHp;
        enemy_nowHp = _maxHp;
        enemy_atkDmg = _atkDmg;
        enemy_moveSpeed = _movespeed;
        enemy_atkSpeed = _atkDelay;
    }

    public MainPlayer player;
    public FirstCat AL01;
    Image nowHpbar;

    private void Start()
    {
        hpBar = Instantiate(prfHpBar, canvas.transform).GetComponent<RectTransform>();
       
        if(name.Equals("M01"))
        {
            SetEnemyStatus("M01", 100, 5, 1, 1);

        }
        nowHpbar = hpBar.transform.GetChild(0).GetComponent<Image>();
        
    }
    private void Update()
    {
        
        Collider2D[] target = Physics2D.OverlapBoxAll(atkBox.position, atkBox.localScale, 0, targetMask);//��ġ ũ��, ȸ����, ������ ���̾� / ���簢�� ������ ���ϴ� ��� �浹ü ��� ������ 
        if (target.Length != 0)
        {
            if (currentTime < enemy_atkSpeed)
            {
                currentTime += Time.deltaTime;
            }
            else
            {
                Debug.Log("���� . ���� "); //������ 
                EnemyAttack(target);
            }
        }
        else
        {
            Debug.Log("�̵�"); //�װ� �ƴϸ� �̵��Ѵ� 
            EnemyMove();
        }

        Vector3 _hpBarPos =
           Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + height, 0));
        hpBar.position = _hpBarPos;
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

    //void EnemyHpBar()
    //{
    //    //���࿡ �÷��̾ ������ ���� ������ true�϶�
    //    //enemyHpbar�� ��ġ�� �����ִ� ������ ��ġ�� ��� ��� �� + y �� ��ǥ(+) �� �����Ѵ�

    //}
    //���� �⺻���� �̵��̴�.
    void EnemyMove()
    {
        transform.Translate(Vector2.left * Time.deltaTime * enemy_moveSpeed);
        
    }

    //���� �⺻���� �����̴�
    void EnemyAttack(Collider2D[] target)
    {
        Debug.Log(target[0].name);
        currentTime = 0;
        EnemyAnimator.SetTrigger("Attack");
    }

    //��_����� : ����
    void UseDebuff_bleeding()
    {
        //���� ���� ���� �ʴ� Hp-2
        //���� �ð� 3��
    }

    //��_���� : ����Ŀ
    void Usebuff_berserk()
    {
        //����Ŀ ���� ����
        //���ӽð� 3��
    }

    //���� ������ ����, ������ ���
    void EnemyTakeDamage(float dmg)
    {
        enemy_nowHp = enemy_nowHp - dmg;
        if(enemy_nowHp <=0)
        {
            enemy_nowHp = 0;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("OurCats"))
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
    //{
    //    if(col.CompareTag("Player"))
    //    {
    //        if(player.attacked)
    //        {
    //            enemy_nowHp -= player.SkillDmg;
    //            Debug.Log(enemy_nowHp);
    //            player.attacked = false;
    //            if(enemy_nowHp<=0)
    //            {
    //                Destroy(gameObject);
    //                Destroy(hpBar.gameObject);
    //            }
    //        }
    //    }
    //    if (col.CompareTag("OurCats"))
    //    {
    //        if (AL01.isAttacked)
    //        {
    //            enemy_nowHp -= AL01.FirstCat_atkDmg;
    //            Debug.Log(enemy_nowHp);
    //            AL01.isAttacked = false;
    //            if (enemy_nowHp <= 0)
    //            {
    //                Destroy(gameObject);
    //                Destroy(hpBar.gameObject);
    //            }
    //        }
    //    }
}
//private void OnTriggerEnter2D(Collider2D collider)
//{
//    if (collider.CompareTag("AL01"))
//    {
//        CanMove = false;
//        EnemyAnimator.SetTrigger("Attack");
//        InvokeRepeating("nowhp", 1f, 1f);
//    }
//}

