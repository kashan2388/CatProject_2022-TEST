using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hpbar : MonoBehaviour
{
    private Camera uiCamera;
    private Canvas canvas;
    private RectTransform rectParent;
    private RectTransform rectHp;

    public Vector3 offset = Vector3.zero;

    public Transform enemyTr;   
    void Start()
    {
        canvas = GetComponentInParent<Canvas>();//부모가 가지고 있는 canvas 가져오기 EnemyHpBar canvas
        uiCamera = canvas.worldCamera;
        rectParent = canvas.GetComponent<RectTransform>();
        rectHp = this.gameObject.GetComponent<RectTransform>();
        
    }

    void LateUpdate()
    {
        var screenPos = Camera.main.WorldToScreenPoint(enemyTr.position + offset); //월드 좌표 3d 를 스크린 좌표 2d로 변경
        var localPos = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectParent, screenPos, uiCamera, out localPos);
        //스크린 좌표에서 캔버스로 사용할 수 있는 좌표로 변경

        rectHp.localPosition = localPos; //그 좌표를 localPos에 저장 
    }
}
