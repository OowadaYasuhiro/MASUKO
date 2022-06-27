public class MainGameCharacterState : MainGameCharacterDamageModel
{
    internal enum CharacterState
    {
        //出撃可能
        Standby,
        //待機
        Wait,
        //動く
        Run,
        //スタン
        Stan,
        //戦闘
        Fight,
        //スキル使用
        DoSkill,
        //帰る
        RunAway,
        //撤退
        Recovery,
        //出撃準備中
        Resting,
        //死亡
        Dead,
    }
    internal CharacterState charactorState = new CharacterState();

    internal enum CharacterAnimState
    {
        Wait,
        Fait,
        Win,
        Lose,
        Walk,
        Run,
        Die,
        PickUp
    }
    internal CharacterAnimState charactorAnimState = new CharacterAnimState();
}
