﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MainGameCharactorModel
{
    //戦闘時間
    const float maxFightTime = 10f;
    float fightTime;


    public Enemy(string name)
    {
        this.name = name;
    }

    private void Start()
    {
        charactorState = CharactorState.Standby;
        charactorAnimState = CharactorAnimState.Wait;
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharactorState.Run:

                break;
        }
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
