using UnityEngine;

public class MainGameCharactorModel : MainGameCharactorState
{
    //名前
    protected string name;
    //向き
    protected bool directionRight;
    //座標
    protected Vector2 position;
    //移動用
    protected Vector2[] targetPosition;
    protected Vector2 latePosition;
    Vector2 arrow;
    int moveTargetPointer = 0;
    bool next = true;
    //移動速度
    protected float moveSpeed;
    //攻撃範囲
    protected Vector2[] attackRange;
    //視界範囲
    protected Vector2[] viewRange;
    //接敵
    protected bool findEnemy;
    //基本ステータス攻撃力
    protected int baseAttackPower;
    //攻撃力計算結果
    protected int resultingAttackPower;

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
}
