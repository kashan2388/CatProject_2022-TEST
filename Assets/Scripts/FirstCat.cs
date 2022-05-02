using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstCat : MonoBehaviour //������ �������� ���� 
{

    public float height = 1.7f;
    public bool CanMove = true;
    public bool isAttacked = false;
    public Animator fcanimator;

    [SerializeField] string FirstCat_Name;
    [SerializeField] private float FirstCat_maxHp;
    public float FirstCat_nowHp;
    public float FirstCat_moveSpeed;
    public int FirstCat_atkDmg;
    public int FirstCat_atkSpeed;
    [SerializeField] private float FirstCat_atkDuration; //���� ���� �ð� 

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
        //���࿡ �÷��̾ ������ ���� ������ true�϶�
        //enemyHpbar�� ��ġ�� �����ִ� ������ ��ġ�� ��� ��� �� + y �� ��ǥ(+) �� �����Ѵ�

    }
    void FirstCatMove()
    {
        transform.Translate(Vector2.right * Time.deltaTime * FirstCat_moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Enemy"))
        {
            CanMove = false;
            isAttacked = true;
            fcanimator.SetTrigger("Attack");
            InvokeRepeating("nowhp", 1f, 1f);
        }
    }

    public void nowhp()
    {
        FirstCat_nowHp -= 8;
    }
}
