using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void LateUpdate()
    //{
    //    transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
    //    transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    //}
}
