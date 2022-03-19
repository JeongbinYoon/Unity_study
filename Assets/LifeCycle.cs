using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Awakke : ���� ������Ʈ ������ ��, ���� ����
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ���ϴ�.");
    }

    // OnEnable : ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����Ͽ����ϴ�.");
    }

    // Start : ������Ʈ ���� ����, ���� ����
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    // FixedUpdate : ���� ���� ������Ʈ
    // ������ ���� �ֱ�� CPU�� ���� ���
    // 1�ʿ� �� 50ȸ ȣ��
    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    // Update : ���� ���� ������Ʈ
    // ȯ�濡 ���� ���� �ֱⰡ ������ �� ����
    void Update()
    {
        Debug.Log("���� ���!!");
    }

    // LateUpdate : ��� ������Ʈ ���� ��
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��");
    }

    // OnDisable : ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α��ξƿ��Ͽ����ϴ�.");
    }

    // OnDestroy : ���� ������Ʈ�� ������ ��
    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�.");
    }
}
