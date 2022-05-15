using static Constant;

//ダメージを表すクラス
public class Damage
{
    //ダメージのタイプ
    string type;
    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            if (value != physicsDamage || value != zyuGeki || value != zyuRyoku)
            {
                if (value.Contains("physics") || value.Contains("Damage"))
                {
                    type = physicsDamage;
                }
                if (value.Contains("zyu"))
                {
                    if (value.Contains("Geki"))
                    {
                        type = zyuGeki;
                    }
                    else if (value.Contains("Ryoku"))
                    {
                        type = zyuRyoku;
                    }
                }
            }
            else
            {
                type = value;
            }
        }
    }

    //ダメージ量
    public int value;

}
