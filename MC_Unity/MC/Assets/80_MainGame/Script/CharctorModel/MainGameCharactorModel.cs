using System.Collections;
using UnityEngine;

public delegate void SkillEvent();

public class MainGameCharactorModel : MainGameCharactorState
{
    //名前
    protected string Charactorname;
    //向き
    protected bool directionRight;
    //座標
    internal Vector2 position;
    //移動用
    protected Vector2[] targetPosition;
    protected Vector2 latePosition;
    Vector2 arrow;
    int moveTargetPointer = 0;
    bool next = true;
    //移動速度
    protected float moveSpeed;
    //攻撃範囲
    internal Vector2[] attackRange;
    //視界範囲
    protected Vector2[] viewRange;
    //接敵
    internal bool findEnemy;
    internal MainGameCharactorModel[] targetEnemy;
    //基本ステータス攻撃力
    protected int baseAttackPower;
    //攻撃力計算結果
    protected int resultingAttackPower;
    //スキル
    protected SkillEvent skillEvent;

    //移動
    protected void Move(float timeLine)
    {
        if (next == true)
        {
            arrow = targetPosition[moveTargetPointer] - position;
            next = false;
        }
        if (next == false)
        {
            position += arrow * timeLine * moveSpeed;
            Vector2 compareArrow = targetPosition[moveTargetPointer] - position;
            if (!(arrow.Equals(compareArrow.normalized)) || position == targetPosition[moveTargetPointer])
            {
                position = targetPosition[moveTargetPointer];
                moveTargetPointer++;
                next = true;
            }
        }
    }

    //ノックバック
    protected void Knockback(bool[,] map)
    {
        if (map[(int)(targetPosition[moveTargetPointer - 1] + (-arrow)).x , (int)(targetPosition[moveTargetPointer - 1] + (-arrow)).y] == true)
        {
            position = position + (-arrow);
            moveTargetPointer--;
            targetPosition[moveTargetPointer] = targetPosition[moveTargetPointer + 1] + (-arrow);
        }
        else
        {
            position = targetPosition[moveTargetPointer - 1];
            next = false;
        }
    }

    public void AddSkillEvent(SkillEvent skillEvent)
    {
        this.skillEvent += skillEvent;
    }

    protected void ReMoveAllEvents()
    {
        foreach (var d in skillEvent.GetInvocationList())
        {
            skillEvent -= (SkillEvent)d;
        }
    }

    //何フレーム実行するか(0で1回)、何フレーム毎に実行するか(1で毎フレーム)、
    protected IEnumerator DoSkillEvent(MainGameCharactorModel target, int time, int doTick, /*MainGameCharactorModel coller*/ SkillEvent skillEvent)
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
