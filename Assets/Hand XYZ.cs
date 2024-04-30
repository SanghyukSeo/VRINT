using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class HandPositionLogger : MonoBehaviour
{
    public Transform handTransform; // 손의 Transform 참조

    private void Start()
    {
        if (handTransform == null)
        {
            Debug.LogError("handTransform이 할당되지 않았습니다. Inspector에서 손을 할당하세요.");
        }
        else
        {
            // 1초 간격으로 로그를 기록하는 Coroutine 시작
            StartCoroutine(LogHandPosition());
        }
    }

    private IEnumerator LogHandPosition()
    {
        while (true) // 무한 루프
        {
            if (handTransform != null)
            {
                // 손의 위치를 로그로 기록
                Debug.Log("손의 위치: " + handTransform.position);
            }

            // 1초 대기
            yield return new WaitForSeconds(1);
        }
    }
}
