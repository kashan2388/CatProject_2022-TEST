using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp_Enmey : MonoBehaviour
{


    [SerializeField] Checker Atk_Trigger;
    [SerializeField] Checker Body_Trigger;
    void Update()
    {
        if(Atk_Trigger.Touched)
        {
            Atk_Trigger.Touched = false;
            Debug.Log("공격해야지!");
        }

        if(Body_Trigger.Touched)
        {
            Body_Trigger.Touched = false;
            Debug.Log("맞았다");
        }
    }
}
