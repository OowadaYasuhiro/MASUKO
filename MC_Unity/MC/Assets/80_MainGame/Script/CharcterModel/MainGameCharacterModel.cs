using UnityEngine;

public delegate void SkillEvent();

public class MainGameCharacterModel : MainGameCharacterState
{
    //名前(名前で中身の有無を確認)
    protected string Charactername = "";
    //ステージに出ているかどうか
    internal bool displaying;
    //向き
    internal bool directionRight;
    //座標
    internal Vector2 position;
    //移動用
    protected Vector2[] targetPosition;
    protected Vector2 latePosition;
    protected Vector2 targetObject;
    Vector2 arrow;
    int moveTargetPointer = 0;
    bool next = true;
    //移動速度
    protected float moveSpeed;
    //攻撃範囲
    internal Vector2[] attackRange;
    //視界範囲
    internal Vector2[] viewRange;
    //接敵
    internal bool findEnemy;
    internal MainGameCharacterModel[] targetEnemy;
    //基本ステータス攻撃力
    protected int baseAttackPower;
    //攻撃力計算結果
    protected int resultingAttackPower;
    //スキルイベント
    protected SkillEvent skillEvent;

    public MainGameCharacterModel() : base()
    {
        ;
    }

    //名前取得
    internal string GetName()
    {
        return Charactername;
    }

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
                if (position == targetObject)
                {
                    charactorState = CharacterState.RunAway;
                }
                moveTargetPointer++;
                next = true;
            }
        }
    }

    //ノックバック
    protected void Knockback(bool[,] map)
    {
        if (map[(int)(targetPosition[moveTargetPointer - 1] + (-arrow)).x, (int)(targetPosition[moveTargetPointer - 1] + (-arrow)).y] == true)
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
}
