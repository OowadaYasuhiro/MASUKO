using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public partial class Player
{
    //コンストラクターから呼び出し、フィールドの情報を埋めていく
    void Setting(int number)
    {
        player = true;
        if (number == 1)
        {
            Charactor? FDC1 = Master.formationdeta.GetCharactor1();
            //Charactorname = FDC1.GetName();
        }
        if (number == 2)
        {

        }
    }
}
