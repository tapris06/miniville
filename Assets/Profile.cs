using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    public Image mark1;
    public Image mark2;
    public Image mark3;
    public Image mark4;
    public Text Name;
    public Sprite OnState;
    public Sprite OffState;
    public Text Coin;
    int coin;
    void SetName(string name){

    }
    void OnSp(int i){
        if(i==1)mark1.sprite=OnState;
        else if(i==2)mark2.sprite=OnState;
        else if(i==3)mark3.sprite=OnState;
        else mark4.sprite=OnState;
    }
    void OffSp(int i){
        if(i==1)mark1.sprite=OffState;
        else if(i==2)mark2.sprite=OffState;
        else if(i==3)mark3.sprite=OffState;
        else mark4.sprite=OffState;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
