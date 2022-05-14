﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormationDeta
{
     private Charactor? selectcharactor1;
     private string charactor1artifact1;
     private string charactor1artifact2;
     private string charactor1artifact3;

     private Artifact[] charactor1Artifacts = {new Artifact(),new Artifact(),new Artifact()};

     private Charactor? selectcharactor2;
     private string charactor2artifact1;
     private string charactor2artifact2;
     private string charactor2artifact3;
     private Artifact[] artifacts;

    private RecoveryOfBelongingsScreen_Deta data = new RecoveryOfBelongingsScreen_Deta();

    public void SetSelectCharacter1(Charactor? character)
    {
        this.selectcharactor1 = character;
    }

    public void SetSelectCharacter2(Charactor? character)
    {
        this.selectcharactor2 = character;
    }

    public void SetCharactor1Artifact(int index,Artifact artifact)
    {
        this.charactor1Artifacts[index] = artifact;
    }
    public Artifact GetCharactor1Artifact(int index)
    {
        return this.charactor1Artifacts[index];
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
    }

    public  void Load()
    {
        if (PlayerPrefs.GetString("selectcharactor1", "unknown").Equals("unknown"))
        {
            selectcharactor1 = null;
        }
        else
        {
            selectcharactor1 = JsonUtility.FromJson<Charactor>(PlayerPrefs.GetString("selectcharactor1"));
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
            selectcharactor2 = JsonUtility.FromJson<Charactor>(PlayerPrefs.GetString("selectcharactor2"));
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
    }
}

public struct Charactor
{
    private string name;
    private int level;
    private int credibility;
    private int skill1level;
    private int skill2level;
    private int skill3level;
    private int ultlevel;
    private int passiveskilllevel;
    private int potentialflowering;

    private int hp;
    private int atk;
    private int def;
    private string passiveSkillName;
    private string passiveSkillEffect;

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

    public string GetName()
    {
        return this.name;
    }

    public int GetLevel()
    {
        return this.level;
    }
    public void SetLevel(int value)
    {
        this.level = value;
    }

    public int GetCredibility()
    {
        return this.credibility;
    }
    public void SetCredibility(int value)
    {
        this.credibility = value;
    }

    public int GetSkill1Level()
    {
        return this.skill1level;
    }
    public void SetSkillLevel(int value)
    {
        this.skill1level = value;
    }

    public int GetSkill2Level()
    {
        return this.skill2level;
    }
    public void SetSkill2Level(int value)
    {
        this.skill2level = value;
    }

    public int GetSkill3Level()
    {
        return this.skill3level;
    }
    public void SetSkill3Level(int value)
    {
        this.skill3level = value;
    }

    public int GetUltLevel()
    {
        return this.ultlevel;
    }
    public void SetUltLevel(int value)
    {
        this.ultlevel = value;
    }

    public int GetPassiveSkillLevel()
    {
        return this.passiveskilllevel;
    }
    public void SetPassiveSkillLevel(int value)
    {
        this.passiveskilllevel = value;
    }

    public int GetPotentialflowering()
    {
        return this.potentialflowering;
    }
    public void SetPotentialflowering(int value)
    {
        this.potentialflowering = value;
    }

    public int GetHp()
    {
        return this.hp;
    }
    public void SetHp(int value)
    {
        this.hp = value;
    }

    public int GetAtk()
    {
        return this.atk;
    }
    public void SetAtk(int value)
    {
        this.atk = value;
    }

    public int GetDef()
    {
        return this.def;
    }
    public void SetDef(int value)
    {
        this.def = value;
    }

    public string GetPassiveSkillName()
    {
        return this.passiveSkillName;
    }
    public void SetPassiveSkillName(string name)
    {
        this.passiveSkillName = name;
    }

    public string GetPassiveSkillEffect()
    {
        return this.passiveSkillEffect;
    }
    public void SetPassiveSkillEffect(string text)
    {
        this.passiveSkillEffect = text;
    }
}

public class Artifact
{
    private string name;
    private int level;
    private Color testColor;
    private int rarity;
    private string addStatus;
    private int addValue;
    private string seriesTag;
    private Sprite icon;

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
    }
}
