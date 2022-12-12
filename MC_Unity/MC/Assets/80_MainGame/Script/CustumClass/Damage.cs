using static Constant;

//ダメージを表すクラス
public class Damage
{
    //ダメージのタイプ
    public DamageType type;

    //ダメージ量
    public int value;

    public Damage(DamageType type,int value)
    {
        this.type = type;
        this.value = value;
    }
}
