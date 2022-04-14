using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private static EnemySpawn instance;

    public GameObject enemy;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InvokeRepeating("CreateEnemy", 6f, 6f);
    }

    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemy);
    }

    public static void Cancel()
    {
        instance.CancelInvoke();
    }

   
}
