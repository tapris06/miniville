using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    //public Card card = new Card();
    List<Tuple<string,int,int,int,int,Sprite>> CardData = new List<Tuple<string,int,int,int,int,Sprite>>();
    for(int i = 0; i < 4; i++){
        list.Add(new Tuple<string,int,int,int,int,Sprite>("밀밭",1,1,1,1,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("목장",1,2,2,1,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("빵집",2,2,3,1,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("카페",3,3,3,2,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("편의점",2,4,4,2,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("숲",1,5,5,3,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("경기장",4,6,6,6null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("전시장",4,6,6,8,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("TV방송국",4,6,6,7,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("치즈공장",2,1,1,5,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("가구공장",2,1,1,3,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("광산",1,1,1,6,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("패밀리레스토랑",3,1,1,3,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("사과밭",1,1,1,3,null));
        list.Add(new Tuple<string,int,int,int,int,Sprite>("농산물시장",2,1,1,2,null));
    }
    Tuple<string,int,int,int,int,Sprite> Draw(){
        int i = Random.range(0,CardData.Count);
        Tuple<string,int,int,int,int,Sprite> r = CardData[i];
        CardData.RemoveAt(i);
        return r
    }
    
    void Start()
    {
        Debug.Log(Draw());
    }

    void Update()
    {
        
    }

}
