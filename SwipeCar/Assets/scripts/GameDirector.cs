using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject carGo;
    GameObject flagGo;
    GameObject distanceGo;
    
    // Start is called before the first frame update
    void Start()
    {
        //�ڵ���
        this.carGo = GameObject.Find("car");
        //���
        this.flagGo = GameObject.Find("flag");

        //ui (text)
        this.distanceGo = GameObject.Find("Distance");

        Debug.LogFormat("this.carGo:{0}", this.carGo);
        Debug.LogFormat("this.flagGo:{0}", this.flagGo);
        Debug.LogFormat("this.distanceGo:{0}", this.distanceGo);

        
    }
    private bool isGameOver = false;
    // Update is called once per frame
    void Update()
    {
        //�� �����Ӹ��� ����߰� �ڵ��� ������ �Ÿ��� �»��ؼ� ui�� ���
        float distanceX = this.flagGo.transform.position.x - this.carGo.transform.position.x;
        Text text = distanceGo.GetComponent<Text>();
        text.text = distanceX.ToString();
        text.text = string.Format("��ǥ�������� �Ÿ�{0:0.00}m", distanceX);
        if (distanceX <= 0)
        {
            text.text = string.Format("���� ����");
            if (this.isGameOver == false)
            {
                CarController carController = this.carGo.GetComponent<CarController>();
                carController.PlayLoseSound();
                this.isGameOver = true;
            }
        }
    }
}
