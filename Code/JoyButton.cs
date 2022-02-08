using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class JoyButton : MonoBehaviour
{
    public Transform stick; // 조이스틱

    private Vector3 StickFirstpos; //조이스틱의 처음 위치
    private Vector3 JoyVec; //조이스틱의 백터(방향)
    private float Radius; //조이스틱 배경의 반 지름;
    
    [SerializeField] public float m_moveSpeed = 2;
    private void Start()
    {
        
        Radius = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
        StickFirstpos = stick.transform.position;

        //캔버스 크기에 대한 반지름 조절
        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Radius *= Can;
    }
    //드래그
    

    public void OnMouseDrag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Pos = Data.position;

        // 조이스틱을 이동시킬 방향을 구함.(오른쪽,왼쪽,위,아래)
        JoyVec = (Pos - StickFirstpos).normalized;

        // 조이스틱의 처음 위치와 현재 내가 터치하고 있는 위치의 거리를 구한다.
        float Dis = Vector3.Distance(Pos, StickFirstpos);

        //거리가 반지름보다 작으면 조이스틱을 현재 터치하고 있는곳으로 이동
        if (Dis < Radius)
        {
            stick.position = StickFirstpos + JoyVec * Dis;
        }
        //거리가 반지름보다 커지면 조이스틱을 반지름의 크기만큼만 이동
        else
        {
            stick.position = StickFirstpos + JoyVec * Dis;
        }
    }
        //드래그 끝
       public void DragEnd()
        {
            stick.position = StickFirstpos;
            JoyVec = Vector3.zero;
        }


    }



