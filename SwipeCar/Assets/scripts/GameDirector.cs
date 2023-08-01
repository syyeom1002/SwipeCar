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
        //자동차
        this.carGo = GameObject.Find("car");
        //깃발
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
        //매 프레임마다 ㅏ깃발과 자동차 사이의 거리를 걔산해서 ui에 출력
        float distanceX = this.flagGo.transform.position.x - this.carGo.transform.position.x;
        Text text = distanceGo.GetComponent<Text>();
        text.text = distanceX.ToString();
        text.text = string.Format("목표지점까지 거리{0:0.00}m", distanceX);
        if (distanceX <= 0)
        {
            text.text = string.Format("게임 오버");
            if (this.isGameOver == false)
            {
                CarController carController = this.carGo.GetComponent<CarController>();
                carController.PlayLoseSound();
                this.isGameOver = true;
            }
        }
    }
}
