using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationDeta
{
    Charactor? selectcharactor1;
    string charactor1artifact1;
    string charactor1artifact2;
    string charactor1artifact3;
    Charactor? selectcharactor2;
    string charactor2artifact1;
    string charactor2artifact2;
    string charactor2artifact3;
    Artifact[] artifacts;

    public void Save() {
        PlayerPrefs.SetString("selectcharactor1", JsonUtility.ToJson(selectcharactor1));
        PlayerPrefs.SetString("charactor1artifact1", charactor1artifact1);
        PlayerPrefs.SetString("charactor1artifact2", charactor1artifact2);
        PlayerPrefs.SetString("charactor1artifact3", charactor1artifact3);
        PlayerPrefs.SetString("selectcharactor2", JsonUtility.ToJson(selectcharactor2));
        PlayerPrefs.SetString("charactor2artifact1", charactor2artifact1);
        PlayerPrefs.SetString("charactor2artifact2", charactor2artifact2);
        PlayerPrefs.SetString("charactor2artifact3", charactor2artifact3);
        PlayerPrefs.SetString("artifacts",JsonHelper.ToJson<Artifact>(artifacts));
    }

    public void Load()
    {
        selectcharactor1 = JsonUtility.FromJson<Charactor>(PlayerPrefs.GetString("selectcharactor1"));
        charactor1artifact1 = PlayerPrefs.GetString("charactor1artifact1");
        charactor1artifact2 = PlayerPrefs.GetString("charactor1artifact2");
        charactor1artifact3 = PlayerPrefs.GetString("charactor1artifact3");
        selectcharactor2 = JsonUtility.FromJson<Charactor>(PlayerPrefs.GetString("selectcharactor2"));
        charactor2artifact1 = PlayerPrefs.GetString("charactor2artifact1");
        charactor2artifact2 = PlayerPrefs.GetString("charactor2artifact2");
        charactor2artifact3 = PlayerPrefs.GetString("charactor2artifact3");
        artifacts = JsonHelper.FromJson<Artifact>(PlayerPrefs.GetString("artifacts"));
    }
}

public struct Charactor
{
    string name;
    int level;
    int credibility;
    int skill1level;
    int skill2level;
    int skill3level;
    int ultlevel;
    int pssiveskilllevel;
    int potentialflowering;

    public Charactor(string name,int level, int credibility, int skill1level, int skill2level, int skill3level, int ultlevel, int pssiveskilllevel, int potentialflowering)
    {
        this.name = name;
        this.level = level;
        this.credibility = credibility;
        this.skill1level = skill1level;
        this.skill2level = skill2level;
        this.skill3level = skill3level;
        this.ultlevel = ultlevel;
        this.pssiveskilllevel = pssiveskilllevel;
        this.potentialflowering = potentialflowering;
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
        pssiveskilllevel = 1;
        potentialflowering = 0;
    }
}

public class Artifact
{
    string name;
    int level;
}
