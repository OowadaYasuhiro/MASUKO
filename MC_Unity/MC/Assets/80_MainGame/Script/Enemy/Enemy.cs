using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
