public class MainGameCharactorDamageModel : MainGameCharactorTag
{
    //生死
    protected bool alive { get; set;}

    //体力
    protected int hp;
    protected int maxHp;
    //耐性(カット率)
    protected int physicsDamageResistance;
    protected int zyuGekiResistance;
    protected int zyuRyokuResistance;

    /*protected MainGameCharactorDamageModel(int maxHp, int physicsDamageResistance, int zyuGekiResistance, int zyuRyokuResistance)
    {
        hp = maxHp;
        this.maxHp = maxHp;
        this.physicsDamageResistance = physicsDamageResistance;
        this.zyuGekiResistance = zyuGekiResistance;
        this.zyuRyokuResistance = zyuRyokuResistance;
    }*/

    protected void AddDamage(Damage damage)
    {
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
    }
}
