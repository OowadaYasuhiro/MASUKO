using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizationScreen_Deta 
{
    public static bool isCharaSelect = false;
    public static bool isLeftCharacter = true;
    public static int armorNum;

    public static int leftCharacterNum;
    public static int rightCharacterNum;

    public static Charactor demon = new Charactor("悪魔",1,0,1,1,1,1,1,0,450,140,60,"悪魔のパッシブ","通常攻撃に自身の\n攻撃力3%の追加の\nダメージを与える");
    public static Charactor poltergeist = new Charactor("ポルターガイスト",1,0,1,1,1,1,1,0,520,110,75,"ポルターのパッシブ","自身の配置で\n味方の攻撃力を自身の\n攻撃力の5%上昇する");
    public static Charactor ogre = new Charactor("鬼",1,0,1,1,1,1,1,0,750,50,120,"鬼のパッシブ","敵から攻撃を受けると\n3秒間防御力が20%\n上昇する(CT:20s)");
    public static Charactor zasikiwarasi = new Charactor("座敷童",1,0,1,1,1,1,1,0,700,100,150,"座敷童のパッシブ","ゲーム開始時に10pt\n怨念が溜まった状態で\nゲームを始める");
    public static Charactor ghost = new Charactor("幽霊",1,0,1,1,1,1,1,0,500,120,70,"幽霊のパッシブ","スキルを使用したとき\n怨念の回収量が\n1.1倍になる");


    public static readonly string[] synagySkills = {"ATK+25", "パッシブスキル+1", "再配置-5s", "攻撃速度上昇+0.1s", "攻撃速度上昇+0.1s", "パッシブスキル+1", "パッシブスキル+1", "HP+100", "再配置-5s", "ATK+25" };

}
