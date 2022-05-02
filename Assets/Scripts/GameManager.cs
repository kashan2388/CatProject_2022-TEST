using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Timer timer;
    MainPlayer mainplayer;

    [SerializeField] private GameObject enemyprefab;


    public float Spawn_DelayTime; //�� ���� �ֱ�
    [SerializeField] private float Spawn_RepeatTime;
    [SerializeField] private int pointX;
    [SerializeField] private int pointY;


    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        InvokeRepeating("CreateEnemy", Spawn_DelayTime, Spawn_RepeatTime);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void GameOver()
    {
        if (timer.PlayLimitTime <= 0)
        {
            isGameOver = true;
        }
        if(mainplayer.Player_Hp<=0)
        {
            isGameOver = true;
        }

    }

    void CreateEnemy()
    {
        Instantiate(enemyprefab, new Vector2(pointX, pointY), Quaternion.identity); //���� ���� ���� ������Ʈ ���� ����  (���� ������Ʈ��, Vector3 position, ȸ����

    }
}
