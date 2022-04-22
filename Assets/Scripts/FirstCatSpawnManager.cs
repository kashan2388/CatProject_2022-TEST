using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCatSpawnManager : MonoBehaviour
{
    public GameObject Cat;

    public void FirstCatSpawn()
    {
        Instantiate(Cat);
    }
}




