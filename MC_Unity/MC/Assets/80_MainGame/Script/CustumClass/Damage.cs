<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using static Constant;

//ダメージを表すクラス
=======
﻿//ダメージを表すクラス
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
﻿using static Constant;

//ダメージを表すクラス
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
=======
﻿//ダメージを表すクラス
>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350
public class Damage
{
    //ダメージ属性
    public const string physicsDamage = "physicsDamage";
    public const string zyuGeki = "zyuGeki";
    public const string zyuRyoku = "zyuRyoku";
    //ダメージのタイプ
<<<<<<< HEAD
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
    public const string physicsDamage = "physicsDamage";
    public const string zyuGeki = "zyuGeki";
    public const string zyuRyoku = "zyuRyoku";
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
=======
    public string type;
>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350

    //ダメージ量
    public int value;

}
