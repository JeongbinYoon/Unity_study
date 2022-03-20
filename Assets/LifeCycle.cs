using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Update : 게임 로직 업데이트
    // 환경에 따라 실행 주기가 떨어질 수 있음
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다..");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 모으는 중");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

        if (Input.GetMouseButton(1))
            Debug.Log("오른쪽 클릭!");

        if (Input.GetMouseButton(2))
            Debug.Log("가운데 버튼 클릭");

        // 점프
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
    }

}
