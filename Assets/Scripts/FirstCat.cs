using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstCat : MonoBehaviour //적에게 공통으로 들어가는 
{

    public float height = 1.7f;
    public bool CanMove = true;
    public Animator fcanimator;

    [SerializeField] string FirstCat_Name;
    [SerializeField] private float FirstCat_maxHp;
    [SerializeField] private float FirstCat_nowHp;
    [SerializeField] private float FirstCat_moveSpeed;
    [SerializeField] private int FirstCat_atkDmg;
    [SerializeField] private int FirstCat_atkSpeed;
    [SerializeField] private float FirstCat_atkDuration; //공격 지속 시간 

    private void SetFirstCatStatus(string _FirstCatName, int _maxHp, int _atkDmg, int _atkSpeed)
    {
        FirstCat_Name = _FirstCatName;
        FirstCat_maxHp = _maxHp;
        FirstCat_nowHp = _maxHp;
        FirstCat_atkDmg = _atkDmg;
        FirstCat_atkSpeed = _atkSpeed;

    }

    private void Start()
    {

    }

    private void Awake()
    {
        fcanimator = GetComponent<Animator>();
    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        if(CanMove == true)
        {
            FirstCatMove();
        }
        
    }

    void FirstCatHpBar()
    {
        //만약에 플레이어가 적에게 공격 당함이 true일때
        //enemyHpbar의 위치는 속해있는 프리팹 위치의 상단 가운데 위 + y 축 좌표(+) 로 결정한다

    }
    void FirstCatMove()
    {
        transform.Translate(Vector2.right * Time.deltaTime * FirstCat_moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("M01"))
        {
            CanMove = false;
            fcanimator.SetTrigger("Attack");
            InvokeRepeating("nowhp", 1f, 1f);
        }
    }

    public void nowhp()
    {
        FirstCat_nowHp -= 8;
    }
}
