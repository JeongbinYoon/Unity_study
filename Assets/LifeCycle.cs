using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Awakke : 게임 오브젝트 생성할 떄, 최초 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되어습니다.");
    }

    // OnEnable : 게임 오브젝트가 활성화 되었을 때
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인하였습니다.");
    }

    // Start : 업데이트 시작 직전, 최초 실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // FixedUpdate : 물리 연산 업데이트
    // 고정된 실행 주기로 CPU를 많이 사용
    // 1초에 약 50회 호출
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    // Update : 게임 로직 업데이트
    // 환경에 따라 실행 주기가 떨어질 수 있음
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    // LateUpdate : 모든 업데이트 끝난 후
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }

    // OnDisable : 게임 오브젝트가 비활성화 되었을 때
    void OnDisable()
    {
        Debug.Log("플레이어가 로그인아웃하였습니다.");
    }

    // OnDestroy : 게임 오브젝트가 삭제될 때
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해체하였습니다.");
    }
}
