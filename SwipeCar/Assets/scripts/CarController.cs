using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0;
    float dampingCoefficient = 0.96f;// ������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� ��ư�� �����ٸ�
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("���� ��ư ����");
            this.moveSpeed = 0.2f;
            
        }
        this.transform.Translate(this.moveSpeed, 0, 0);

        this.moveSpeed *= dampingCoefficient;
    }
}
