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
public class Enemy : MonoBehaviour //적에게 공통으로 들어가는 
{
    public EnemyState mystate1;


    [SerializeField] string enemy_Name; //적 이름

    public GameObject prfHpBar;
    public GameObject canvas;

    RectTransform hpBar;

    public float height = 2.5f;

    public float enemy_maxHp; // 전체 체력
    public float enemy_nowHp; // 현재 체력
    public float enemy_moveSpeed; //적 이동 속도
    public int enemy_atkDmg; // 적 공격력
    [Tooltip("공격 지속 시간(공격 간 딜레이 설정)")]
    public float enemy_atkSpeed; //공격 속도(딜레이) 

    [SerializeField] float currentTime;
    //[Header("애니메이터 설정")]
    //public Animator M01_Animator;
    //public Animator M02_Animator;
    //public Animator M03_Animator;
    //[Header("BOSS 애니메이터")]
    //public Animator MB04_Animator;

    [Header("설정")]
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
        
        Collider2D[] target = Physics2D.OverlapBoxAll(atkBox.position, atkBox.localScale, 0, targetMask);//위치 크기, 회전값, 감지할 레이어 / 직사각형 영역에 속하는 모든 충돌체 목록 가져옴 
        if (target.Length != 0)
        {
            if (currentTime < enemy_atkSpeed)
            {
                currentTime += Time.deltaTime;
            }
            else
            {
                Debug.Log("감지 . 전투 "); //감지됨 
                EnemyAttack(target);
            }
        }
        else
        {
            Debug.Log("이동"); //그게 아니면 이동한다 
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
    //    //만약에 플레이어가 적에게 공격 당함이 true일때
    //    //enemyHpbar의 위치는 속해있는 프리팹 위치의 상단 가운데 위 + y 축 좌표(+) 로 결정한다

    //}
    //적의 기본적인 이동이다.
    void EnemyMove()
    {
        transform.Translate(Vector2.left * Time.deltaTime * enemy_moveSpeed);
        
    }

    //적의 기본적인 공격이다
    void EnemyAttack(Collider2D[] target)
    {
        Debug.Log(target[0].name);
        currentTime = 0;
        EnemyAnimator.SetTrigger("Attack");
    }

    //적_디버프 : 출혈
    void UseDebuff_bleeding()
    {
        //출혈 상태 정의 초당 Hp-2
        //지속 시간 3초
    }

    //적_버프 : 버서커
    void Usebuff_berserk()
    {
        //버서커 상태 정의
        //지속시간 3초
    }

    //적의 데미지 계산과, 삭제를 담당
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

