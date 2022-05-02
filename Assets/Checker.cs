using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    [SerializeField] int BitLayer;
    public bool Touched;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == BitLayer)
        {
            Touched = true;
        }
    }

}
