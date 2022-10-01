public class MainGameCharacterState : MainGameCharacterDamageModel
{

    public MainGameCharacterState() : base()
    {
        ;
    }

    public enum CharacterState
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
    public CharacterState charactorState = new CharacterState();

    public enum CharacterAnimState
    {
        Wait,
        Fight,
        Stan,
        Win,
        Lose,
        Walk,
        Run,
        Die,
        PickUp
    }
    public CharacterAnimState charactorAnimState = new CharacterAnimState();
}
