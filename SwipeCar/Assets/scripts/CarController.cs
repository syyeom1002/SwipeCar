using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour

{
    private Vector3 startPos;
    private float moveSpeed;
    private float dampingCoefficient = 0.96f;
    public AudioClip[] audioClips;
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
            Debug.LogFormat("down:{0}",Input.mousePosition);
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.LogFormat("up{0}",Input.mousePosition);
            Vector3 endPos = Input.mousePosition;

            float swipeLength =endPos.x - startPos.x;
            Debug.LogFormat("{0}", swipeLength); //ȭ����ǥ���� ���� ������ �Ÿ�

            this.moveSpeed = swipeLength / 500f;
            Debug.LogFormat("movespeed{0}", this.moveSpeed);//���� ���;Ƥ����� ���̿� ������ ���ǵ尡 �޶���

            PlayMoveSound();
                
        }

        
        this.transform.Translate(this.moveSpeed, 0, 0);
        this.moveSpeed *= this.dampingCoefficient;

        
        //b.x-a.x = x��ǥ�ǰŸ� 
    }
    public void PlayMoveSound()
    {
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(this.audioClips[0]);
    }
    public void PlayLoseSound()
    {
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(this.audioClips[1]);
    }
}
