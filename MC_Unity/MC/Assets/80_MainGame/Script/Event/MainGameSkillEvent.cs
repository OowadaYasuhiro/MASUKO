using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.CompilerServices;

//public delegate void SkillEvent();

public class MainGameSkillEvent : MainGameCharacterModel
{
    //何フレーム実行するか(0で1回)、何フレーム毎に実行するか(1で毎フレーム)、
    public IEnumerator DoSkillEvent(MainGame maingame, MainGameCharacterModel target, int time, int doTick, SkillEvent skillEvent )
    {
        int passedTime = 0;
        LOOPPOINT:

        if (passedTime >= doTick)
        {
            target.AddSkillEvent(skillEvent);
            passedTime = 0;
        }
        time--;
        passedTime++;
        
        //時間軸と合わせる
        if (maingame.gameSpeed == 1)
        {
            yield return new WaitForEndOfFrame();
        }
        else
        {
            Loop:
            if (maingame.gameSpeed == 0)
            {
                yield return new WaitForEndOfFrame();
                goto Loop;
            }
            int j = (int)(1f/maingame.gameSpeed);
            for(int i = 0; i < j; i++)
            {
                yield return new WaitForEndOfFrame();
            }
        }
        

        if (time >= 0)
        {
            goto LOOPPOINT;
        }

        Destroy(this);
    }
}
