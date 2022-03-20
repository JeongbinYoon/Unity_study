using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Update : ���� ���� ������Ʈ
    // ȯ�濡 ���� ���� �ֱⰡ ������ �� ����
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�..");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� ������ ��");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");

        if (Input.GetMouseButton(1))
            Debug.Log("������ Ŭ��!");

        if (Input.GetMouseButton(2))
            Debug.Log("��� ��ư Ŭ��");

        // ����
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");
    }

}
