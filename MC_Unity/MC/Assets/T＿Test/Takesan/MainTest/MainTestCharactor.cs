using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTestCharactor : MonoBehaviour
{
    int hp;
    int maxHp;
    float moveSpeed = 0;
    int zyuGekiDamage = 0;
    int zyuRyokuDamage = 0;
    int physicsDamage = 0;
    double zyuGekiResistance = 0;
    double zyuRyokuResistance = 0;
    double physicsDamageResistance = 0;
    Vector2[] attackRange;

    public const string zyuGeki = "zyugeki";
    public const string zyuRyoku = "zyuryoku";
    public const string physics = "physics";

    public int HP { get; set;}
    public int MaxHP { get; set;}
    public float MoveSpeed { get;}

    public void AddDamage(Effect valu)
    {
        switch (valu.type){
            case zyuGeki:

                break;
            case zyuRyoku:

                break;
            case physics:

                break;
        }
    }

    public void DOEffectEvent(Effect effect)
    {
        switch (effect.type){
            case "":

                break;
        }
    }

}

public class Effect
{
    public string type;
    public int valu;
}
