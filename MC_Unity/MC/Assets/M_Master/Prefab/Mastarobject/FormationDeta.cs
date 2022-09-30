using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Constant;

public class FormationDeta
{
    public Charactor? selectcharactor1;
    public string charactor1artifact1;
    public string charactor1artifact2;
    public string charactor1artifact3;
    public Artifact[] charactor1Artifacts = {new Artifact(),new Artifact(),new Artifact()};

    public Charactor? selectcharactor2;
    public string charactor2artifact1;
    public string charactor2artifact2;
    public string charactor2artifact3;
    public Artifact[] charactor2Artifacts = { new Artifact(), new Artifact(), new Artifact() };

    public Artifact[] artifacts;

    public void SetSelectCharacter1(Charactor? character)
    {
        this.selectcharactor1 = character;
    }
    public Charactor? GetCharactor1()
    {
        return this.selectcharactor1;
    }

    public void SetSelectCharacter2(Charactor? character)
    {
        this.selectcharactor2 = character;
    }
    public Charactor? GetCharactor2()
    {
        return this.selectcharactor2;
    }

    public void SetCharactor1Artifact(int index,Artifact artifact)
    {
        this.charactor1Artifacts[index] = artifact;
    }
    public Artifact GetCharactor1Artifact(int index)
    {
        return this.charactor1Artifacts[index];
    }

    public void SetCharactor2Artifact(int index,Artifact artifact)
    {
        this.charactor2Artifacts[index] = artifact;
    }
    public Artifact GetCharactor2Artifact(int index)
    {
        return this.charactor2Artifacts[index];
    }

    public  void Save() {
        if (selectcharactor1 == null)
        {
            PlayerPrefs.SetString("selectcharactor1", "unknown");
        }
        else
        {
            PlayerPrefs.SetString("selectcharactor1", JsonUtility.ToJson(selectcharactor1));
        }
        PlayerPrefs.SetString("charactor1artifact1", charactor1artifact1);
        PlayerPrefs.SetString("charactor1artifact2", charactor1artifact2);
        PlayerPrefs.SetString("charactor1artifact3", charactor1artifact3);
        if (selectcharactor1 == null)
        {
            PlayerPrefs.SetString("selectcharactor2", "unknown");
        }
        else
        {
            PlayerPrefs.SetString("selectcharactor2", JsonUtility.ToJson(selectcharactor2));
        }
        PlayerPrefs.SetString("charactor2artifact1", charactor2artifact1);
        PlayerPrefs.SetString("charactor2artifact2", charactor2artifact2);
        PlayerPrefs.SetString("charactor2artifact3", charactor2artifact3);
        PlayerPrefs.SetString("artifacts",JsonHelper.ToJson<Artifact>(artifacts));

        PlayerPrefs.SetString("ghostLv", "1");
        PlayerPrefs.SetString("zasikiwarasiLv", "1");
        PlayerPrefs.SetString("orgaLv", "1");
        PlayerPrefs.SetString("poltergeistLv", "1");
        PlayerPrefs.SetString("demonLv", "1");
    }

    public  void Load()
    {
        if (PlayerPrefs.GetString("selectcharactor1", "unknown").Equals("unknown"))
        {
            selectcharactor1 = null;
        }
        else
        {
            if (PlayerPrefs.GetString("selectcharactor1").Equals(""))
            {
                selectcharactor1 = null;
            }
            else
            {
                selectcharactor1 = JsonUtility.FromJson<Charactor>(PlayerPrefs.GetString("selectcharactor1"));
            }
        }
        charactor1artifact1 = PlayerPrefs.GetString("charactor1artifact1");
        charactor1artifact2 = PlayerPrefs.GetString("charactor1artifact2");
        charactor1artifact3 = PlayerPrefs.GetString("charactor1artifact3");
        if (PlayerPrefs.GetString("selectcharactor2", "unknown").Equals("unknown"))
        {
            selectcharactor2 = null;
        }
        else
        {
            if (PlayerPrefs.GetString("selectcharactor2").Equals(""))
            {
                selectcharactor2 = null;
            }
            else
            {
                selectcharactor2 = JsonUtility.FromJson<Charactor>(PlayerPrefs.GetString("selectcharactor2"));
            }
        }
        charactor2artifact1 = PlayerPrefs.GetString("charactor2artifact1");
        charactor2artifact2 = PlayerPrefs.GetString("charactor2artifact2");
        charactor2artifact3 = PlayerPrefs.GetString("charactor2artifact3");
        if (PlayerPrefs.GetString("artifacts", "unknown").Equals("unknown"))
        {
            
        }
        else
        {
            artifacts = JsonHelper.FromJson<Artifact>(PlayerPrefs.GetString("artifacts"));
        }

        if (selectcharactor1 == null && selectcharactor2 == null)
        {
            selectcharactor1 = new Charactor("幽霊", 1, 0, 1, 1, 1, 1, 1, 0, 500, 120, 70, "幽霊のパッシブ", "スキルを使用したとき\n怨念の回収量が\n1.1倍になる");
        }
    }
}

public struct Charactor
{
    public string name;
    public int level;
    public int credibility;
    public int skill1level;
    public int skill2level;
    public int skill3level;
    public int ultlevel;
    public int passiveskilllevel;
    public int potentialflowering;

    public int hp;
    public int atk;
    public int def;
    public string passiveSkillName;
    public string passiveSkillEffect;

    public Charactor(string name,int level, int credibility, int skill1level, int skill2level, int skill3level, int ultlevel, int passiveskilllevel, int potentialflowering,int hp,int atk,int def,string passiveNameText,string passiveSkillEffectText)
    {
        this.name = name;
        this.level = level;
        this.credibility = credibility;
        this.skill1level = skill1level;
        this.skill2level = skill2level;
        this.skill3level = skill3level;
        this.ultlevel = ultlevel;
        this.passiveskilllevel = passiveskilllevel;
        this.potentialflowering = potentialflowering;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.passiveSkillName = passiveNameText;
        this.passiveSkillEffect = passiveSkillEffectText;
    }

    public Charactor(string name)
    {
        this.name = name;
        level = 1;
        credibility = 0;
        skill1level = 1;
        skill2level = 1;
        skill3level = 1;
        ultlevel = 1;
        passiveskilllevel = 1;
        potentialflowering = 0;
        hp = 0;
        atk = 0;
        def = 0;
        passiveSkillName = "void";
        passiveSkillEffect = "void";
    }
}

public class Artifact
{
    public string name;
    public int level;
    public Color testColor;
    public int rarity;
    public string addStatus;
    public int addValue;
    public string seriesTag;
    public Sprite icon;

    public string GetName()
    {
        return this.name;
    }
    public int GetLevel()
    {
        return this.level;
    }
    public void SetLevel(int artifactLevel)
    {
        this.level = artifactLevel;
    }
    public Color GetColor()
    {
        return this.testColor;
    }
    public int GetRarity()
    {
        return this.rarity;
    }
    public void SetRarity(int value)
    {
        this.rarity = value;
    }
    public string GetStaus()
    {
        return this.addStatus;
    }
    public int GetAddValue()
    {
        return this.addValue;
    }
    public string GetSeriesTag()
    {
        return this.seriesTag;
    }
    public Sprite GetIcon()
    {
        return this.icon;
    }
    public void SetIcon(Sprite image)
    {
        this.icon = image;
    }

    public Artifact()
    {
        this.name = "noname";
        this.level = 1;
        this.testColor = Color.white;
        this.rarity = 0;
        this.addStatus = "";
        this.addValue = 0;
        this.seriesTag = "";
    }

    public Artifact(string name,Color testColor,int rarity,string status,int value,string series,Sprite image)
    {
        this.name = name;
        this.testColor = testColor;
        this.rarity = rarity;
        this.addStatus = status;
        this.addValue = value;
        this.seriesTag = series;
        this.icon = image;

        this.level = 1;
    }

    public Artifact(string name,int rarity,string bonusStatus,int bonusValue,string tag,Sprite image)
    {
        this.name = name;
        this.level = 1;
        this.rarity = rarity;
        this.addStatus = bonusStatus;
        this.addValue = bonusValue;
        this.seriesTag = tag;
        this.icon = image;
        this.testColor = Color.white;
    }
}
