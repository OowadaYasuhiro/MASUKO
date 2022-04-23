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

    public void AddHP(int valu) 
    {
        hp += valu;
    }

    public void SubHP(int valu)
    {
        hp -= valu;
    }

    public void AddDamage(string type,int valu)
    {
        switch (type){
            case "zyugeki":

                break;
            case "zyuryoku":

                break;
            case "physics":

                break;
        }
    }

    /*public Damage Attack()
    {
        return;
    }*/

}

public class Damage
{
    string type;
    int valu;
}
