public class MainGameCharacterDamageModel : MainGameCharacterTag
{
    //生死
    public bool alive { get; set; }

    //体力
    protected int hp;
    protected int maxHp;
    //耐性(カット率)
    protected int physicsDamageResistance;
    protected int zyuGekiResistance;
    protected int zyuRyokuResistance;

    //ダメージフラグ
    protected bool takeDamage = false;

    public MainGameCharacterDamageModel() : base()
    {
        alive = true;
    }

    public void AddDamage(Damage damage)
    {
        if (alive == true)
        {
            takeDamage = true;
        }
        Invoke(nameof(ExitTakeDamage), 0.5f);
        if (damage.type == Damage.physicsDamage)
        {
            double RPD = 1.0 - (double)physicsDamageResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
        if (damage.type == Damage.zyuGeki)
        {
            double RPD = 1.0 - (double)zyuGekiResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
        if (damage.type == Damage.zyuRyoku)
        {
            double RPD = 1.0 - (double)zyuRyokuResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
        if (hp <= 0)
        {
            alive = false;
        }
    }

    void ExitTakeDamage()
    {
        takeDamage = false;
    }
}
