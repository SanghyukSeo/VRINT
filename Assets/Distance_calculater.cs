using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractionWithCubeGrabbable : MonoBehaviour
{
    public Transform handTransform; // 손의 위치 참조
    private Transform targetObject; // "Cube Grabbable" 객체 참조
    private float interactionDistance = 0.1f; // 10cm 이하
    private bool isInteracted = false; // 상호작용 상태 제어

    void Start()
    {
        // 이름으로 타겟 객체 찾기
        GameObject targetGameObject = GameObject.Find("Cube Grabbable");
        
        if (targetGameObject != null)
        {
            targetObject = targetGameObject.transform;
        }
        else
        {
            Debug.LogError("Cube Grabbable 객체를 찾을 수 없습니다.");
        }
    }

    void Update()
    {
        if (targetObject != null && handTransform != null) // 객체 참조 확인
        {
            // 손과 타겟 객체 사이의 거리 계산
            float distance = Vector3.Distance(handTransform.position, targetObject.position);

            if (distance < interactionDistance && !isInteracted) // 10cm 이하
            {
                Debug.Log("손이 10cm 이하로 접근했습니다.");
                isInteracted = true; // 상호작용 상태를 업데이트
                
                // 원하는 상호작용 로직을 여기서 구현
            }

            if (distance >= interactionDistance && isInteracted) // 10cm 이상이면
            {
                isInteracted = false; // 상호작용 상태를 리셋
            }
        }
    }
}
