using UnityEngine;

public static class Constant
{

    //ステージの変数に代入する定数
    public const string main_ep1_1 = "m11";
    public const string main_ep1_2 = "m12";
    public const string main_ep1_3 = "m13";
    public const string main_ep1_4 = "m14";
    public const string main_ep2_1 = "m21";
    public const string main_ep2_2 = "m22";
    public const string main_ep2_3 = "m23";
    public const string main_ep2_4 = "m24";
    public const string main_ep3_1 = "m31";
    public const string main_ep3_2 = "m32";
    public const string main_ep3_3 = "m33";
    public const string main_ep3_4 = "m34";
    public const string main_ep4_1 = "m41";
    public const string main_ep4_2 = "m42";
    public const string main_ep4_3 = "m43";
    public const string main_ep4_4 = "m44";
    public const string main_ep5_1 = "m51";
    public const string main_ep5_2 = "m52";
    public const string main_ep5_3 = "m53";
    public const string main_ep5_4 = "m54";

    //難易度
    public const string easy = "easy";
    public const string normal = "normal";
    public const string hard = "hard";

    //ダメージ属性
    public const string physicsDamage = "physicsDamage";
    public const string zyuGeki = "zyuGeki";
    public const string zyuRyoku = "zyuRyoku";

    //ゲームステート
    public enum GameState
    {
        BeforeStart,
        PreparationPhase,
        GameRun,
        Wait,
        End
    }

    //敵の名前
    public enum EnemyName
    {
        TUYOGARISYOUNEN,
        NAMIKINASYOUZYO,
        KOISURUGYARU,
        KOWAMOTEYANKI,
        PIENNNAONNNANOKO,
        PIEKIN
    }

    //敵ステート
    public enum Enemystate
    {
        Wait,
        Run,
        Stan,
        Fight,
        RunAway,
        Dead
    }

    //プレイヤーのステート
    public enum Playerstate
    {
        Wait,
        Fight,
        Recovery,
        Dead,
        Resting
    }
}
