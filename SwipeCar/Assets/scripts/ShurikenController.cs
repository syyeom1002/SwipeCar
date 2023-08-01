using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;
    public float moveSpeed=0;
    public float rotateAngle=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("down");
            this.startPos = Input.mousePosition;
            rotateAngle = 10;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("up");
            this.endPos = Input.mousePosition;

            float swipeLength = endPos.y - startPos.y;
            this.moveSpeed = swipeLength / 600f;
            


        }
        this.transform.Rotate(0, 0, rotateAngle);
        this.transform.Translate(0, this.moveSpeed, 0,Space.World);
        
    }
}
