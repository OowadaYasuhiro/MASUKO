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

    public int HP { get; set;}
    public int MaxHP { get; set;}
    public float MoveSpeed { get;}

    public void AddDamage(Damage valu)
    {
        switch (valu.type){
            case "zyugeki":

                break;
            case "zyuryoku":

                break;
            case "physics":

                break;
        }
    }

}

public class Damage
{
    public string type;
    public int valu;
}
