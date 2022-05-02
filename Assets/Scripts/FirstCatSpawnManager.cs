using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCatSpawnManager : MonoBehaviour
{
    public GameObject cat;


    public void FirstCatSpawn()
    {
        Instantiate(cat);

    }
}




