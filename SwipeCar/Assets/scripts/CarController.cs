using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0;
    float dampingCoefficient = 0.96f;// 감쇠계수
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 버튼을 눌렀다면
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("왼쪽 버튼 눌림");
            this.moveSpeed = 0.2f;
            
        }
        this.transform.Translate(this.moveSpeed, 0, 0);

        this.moveSpeed *= dampingCoefficient;
    }
}
