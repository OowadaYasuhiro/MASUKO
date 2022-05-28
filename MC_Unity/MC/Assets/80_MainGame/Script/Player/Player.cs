using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MainGameCharactorModel
{
    //スキル
    bool skill1;
    bool skill2;
    bool skill3;
    //撤退
    bool goback;

    public Player(string name)
    {
        this.name = name;
    }

    private void Start()
    {
        charactorState = CharactorState.Wait;
        charactorAnimState = CharactorAnimState.Wait;
    }
}
