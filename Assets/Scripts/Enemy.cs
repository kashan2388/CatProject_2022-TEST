using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject EnfHapaBar;
    public GameObject canvas;

    RectTransform Em_hpVBar;

    public float height = 1.7f;

    public string enemyName;
    public int maxHp; 
    public int nowHp;
    public int atkDmg;
    public int atkSpeed;
    public float atkDuration; //공격 지속 시간 

    private void SetEnemyStatus(string _enemyName, int _maxHp, int _atkDmg, int _atkSpeed)
    {
        enemyName = _enemyName;
        maxHp = _maxHp;
        nowHp = _maxHp;
        atkDmg = _atkDmg;
        atkSpeed = _atkSpeed;

    }

    void Start()
    {
        //Em_hpVBar = Instantiate(EnfHapaBar, canvas.transform).GetComponent<RectTransform>();
    }

    void Update()
    {
        //Vector3 _Em_hpBarPos =
        //    Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + height, 0));
        //Em_hpVBar.position = _Em_hpBarPos;
    }
    //public float speed;

    //Rigidbody2D rigidbody2D;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    rigidbody2D = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Vector2 position = rigidbody2D.position;

    //    position.x = position.x + Time.deltaTime * speed * -1;

    //    rigidbody2D.MovePosition(position);
    //}
}
