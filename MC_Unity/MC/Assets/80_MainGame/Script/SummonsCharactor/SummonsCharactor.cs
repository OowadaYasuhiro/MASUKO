using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonsCharactor : MainGameCharactorModel
{
    //情報収集
    public void FastUpDate()
    {
        
    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        skillEvent();
        ReMoveAllEvents();
    }

    //結果
    public void LateUpDate()
    {

    }
}
