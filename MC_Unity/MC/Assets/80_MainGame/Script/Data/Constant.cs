using UnityEngine;

public delegate void SkillEvent();

public class Constant : MonoBehaviour
{

    //ステージの変数に代入する定数
    protected const string main_ep1_1 = "m11";
    protected const string main_ep1_2 = "m12";
    protected const string main_ep1_3 = "m13";
    protected const string main_ep1_4 = "m14";
    protected const string main_ep2_1 = "m21";
    protected const string main_ep2_2 = "m22";
    protected const string main_ep2_3 = "m23";
    protected const string main_ep2_4 = "m24";
    protected const string main_ep3_1 = "m31";
    protected const string main_ep3_2 = "m32";
    protected const string main_ep3_3 = "m33";
    protected const string main_ep3_4 = "m34";
    protected const string main_ep4_1 = "m41";
    protected const string main_ep4_2 = "m42";
    protected const string main_ep4_3 = "m43";
    protected const string main_ep4_4 = "m44";
    protected const string main_ep5_1 = "m51";
    protected const string main_ep5_2 = "m52";
    protected const string main_ep5_3 = "m53";
    protected const string main_ep5_4 = "m54";

    //難易度
    protected const string easy = "easy";
    protected const string normal = "normal";
    protected const string hard = "hard";

    //ダメージ属性
    protected const string physicsDamage = "physicsDamage";
    protected const string zyuGeki = "zyuGeki";
    protected const string zyuRyoku = "zyuRyoku";

    //ゲームステート
    public enum GameState
    {
        BeforeStart,
        PreparationPhase,
        GameRun,
        Wait,
        End
    }

    //名前
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
}
