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
        canvas = GetComponentInParent<Canvas>();//�θ� ������ �ִ� canvas �������� EnemyHpBar canvas
        uiCamera = canvas.worldCamera;
        rectParent = canvas.GetComponent<RectTransform>();
        rectHp = this.gameObject.GetComponent<RectTransform>();
        
    }

    void LateUpdate()
    {
        var screenPos = Camera.main.WorldToScreenPoint(enemyTr.position + offset); //���� ��ǥ 3d �� ��ũ�� ��ǥ 2d�� ����
        var localPos = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectParent, screenPos, uiCamera, out localPos);
        //��ũ�� ��ǥ���� ĵ������ ����� �� �ִ� ��ǥ�� ����

        rectHp.localPosition = localPos; //�� ��ǥ�� localPos�� ���� 
    }
}
