﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.CompilerServices;

//public delegate void SkillEvent();

public class MainGameSkillEvent : MainGameCharactorModel
{
    //何フレーム実行するか(0で1回)、何フレーム毎に実行するか(1で毎フレーム)、
    public IEnumerator DoSkillEvent(MainGameCharactorModel target, int time, int doTick, MainGameCharactorModel coller/*, SkillEvent skillEvent*/ )
    {
        int passedTime = 0;
        POINT:

        //SkillEvent skillEvent = 

        if (passedTime >= doTick)
        {
            target.AddSkillEvent(skillEvent);
            passedTime = 0;
        }
        time--;
        passedTime++;

        yield return new WaitForEndOfFrame();
        if (time >= 0)
        {
            goto POINT;
        }
    }
}
