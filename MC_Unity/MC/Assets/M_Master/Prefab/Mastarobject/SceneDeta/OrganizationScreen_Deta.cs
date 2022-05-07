using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizationScreen_Deta 
{
    public static bool isLeftCharacter = true;
    public static int armorNum;

    public static int leftCharacterNum = 0;
    public static int rightCharacterNum = -1;

    public Charactor demon = new Charactor("悪魔",1,0,1,1,1,1,1,0,450,140,60,"悪魔のパッシブ","通常攻撃に自身の\n攻撃力3%の追加の\nダメージを与える\n敵にスキルを当てると\n最大3のスタック獲得");
    public Charactor poltergeist = new Charactor("ポルターガイスト",1,0,1,1,1,1,1,0,520,110,75,"ポルターのパッシブ","自身の配置で\n味方の攻撃力を自身の\n攻撃力の5%上昇する");
    public Charactor ogre = new Charactor("鬼",1,0,1,1,1,1,1,0,750,50,120,"鬼のパッシブ","敵から攻撃を受けると\n3秒間防御力が20%\n上昇する(CT:20s)");
    public Charactor zasikiwarasi = new Charactor("座敷童",1,0,1,1,1,1,1,0,700,100,150,"座敷童のパッシブ","ゲーム開始時に10pt\n怨念が溜まった状態で\nゲームを始める");
    public Charactor ghost = new Charactor("幽霊",1,0,1,1,1,1,1,0,500,120,70,"幽霊のパッシブ","スキルを使用したとき\n怨念の回収量が\n1.1倍になる");

    public enum CharacterName
    {
        ghost,
        zasikiwarasi,
        ogre,
        poltergeist,
        demon
    }

    private string[] synagySkills = {"ab", "ac", "ad", "ae", "bc", "bd", "be", "cd", "ce", "de"};

    public string GetSynagySkills()
    {
        string synagySkillText;

        if ((leftCharacterNum == 0 && rightCharacterNum == 1) || (leftCharacterNum == 1 && rightCharacterNum == 0))
        {
            synagySkillText = this.synagySkills[0];
        }
        else if ((leftCharacterNum == 0 && rightCharacterNum == 2) || (leftCharacterNum == 2 && rightCharacterNum == 0))
        {
            synagySkillText = this.synagySkills[1];
        }
        else if ((leftCharacterNum == 0 && rightCharacterNum == 3) || (leftCharacterNum == 3 && rightCharacterNum == 0))
        {
            synagySkillText = this.synagySkills[2];
        }
        else if ((leftCharacterNum == 0 && rightCharacterNum == 4) || (leftCharacterNum == 4 && rightCharacterNum == 0))
        {
            synagySkillText = this.synagySkills[3];
        }
        else if ((leftCharacterNum == 1 && rightCharacterNum == 2) || (leftCharacterNum == 2 && rightCharacterNum == 1))
        {
            synagySkillText = this.synagySkills[4];
        }
        else if ((leftCharacterNum == 1 && rightCharacterNum == 3) || (leftCharacterNum == 3 && rightCharacterNum == 1))
        {
            synagySkillText = this.synagySkills[5];
        }
        else if ((leftCharacterNum == 1 && rightCharacterNum == 4) || (leftCharacterNum == 4 && rightCharacterNum == 1))
        {
            synagySkillText = this.synagySkills[6];
        }
        else if ((leftCharacterNum == 2 && rightCharacterNum == 3) || (leftCharacterNum == 3 && rightCharacterNum == 2))
        {
            synagySkillText = this.synagySkills[7];
        }
        else if ((leftCharacterNum == 2 && rightCharacterNum == 4) || (leftCharacterNum == 4 && rightCharacterNum == 2))
        {
            synagySkillText = this.synagySkills[8];
        }
        else if ((leftCharacterNum == 3 && rightCharacterNum == 4) || (leftCharacterNum == 4 && rightCharacterNum == 3))
        {
            synagySkillText = this.synagySkills[9];
        }
        else
        {
            synagySkillText = "";
        }

        return synagySkillText;
    }
}
