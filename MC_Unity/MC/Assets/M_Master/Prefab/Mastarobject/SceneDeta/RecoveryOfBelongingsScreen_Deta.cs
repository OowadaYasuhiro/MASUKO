using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryOfBelongingsScreen_Deta 
{
    public enum Series
    {
        Hua,
        Onnnen,
        Rekisen,
        Yujyou,
        Akatuki
    }

    private string[] seriesEffectText = {"再配置-2s","ATK+5","スキルCT-1s","DEF+13", "スキルCT-1s\nスキルを3回発動すると次の通常攻撃のダメージ1.2倍" };

    public string GetSeriesEffects(string series)
    {
        string retText = "";
        switch (series)
        {
            case "Hua":
                retText = seriesEffectText[0];
                break;
            case "Onnnen":
                retText = seriesEffectText[1];
                break;
            case "Rekisen":
                retText = seriesEffectText[2];
                break;
            case "Yujyou":
                retText = seriesEffectText[3];
                break;
            case "Akatuki":
                retText = seriesEffectText[4];
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }

        return retText;
    }

    public Artifact InstantiateCrown(Sprite image,Color color,string series)
    {
        int rarety = 0;
        int bonusValue = 0;

        switch (series)
        {
            case "Hua":
            case "Onnnen":
                rarety = 1;
                bonusValue = 2;
                break;
            case "Rekisen":
            case "Yujyou":
                rarety = 2;
                bonusValue = 5;
                break;
            case "Akatuki":
                rarety = 3;
                bonusValue = 10;
                break;
            default:
                Debug.LogError("Illegal Value");
                break;
        }

        return new Artifact(series + "の冠",color,rarety,"ATK",bonusValue,series,image);
    }

    public Artifact InstantiateBangle(Sprite image, Color color, string series)
    {
        int rarety = 0;
        int bonusValue = 0;

        switch (series)
        {
            case "Hua":
            case "Onnnen":
                rarety = 1;
                bonusValue = 2;
                break;
            case "Rekisen":
            case "Yujyou":
                rarety = 2;
                bonusValue = 5;
                break;
            case "Akatuki":
                rarety = 3;
                bonusValue = 10;
                break;
            default:
                Debug.LogError("Illegal Value");
                break;
        }

        return new Artifact(series + "の腕輪", color, rarety, "DEF", bonusValue, series, image);
    }

    public Artifact InstantiateRing(Sprite image, Color color, string series)
    {
        int rarety = 0;
        int bonusValue = 0;

        switch (series)
        {
            case "Hua":
            case "Onnnen":
                rarety = 1;
                bonusValue = 25;
                break;
            case "Rekisen":
            case "Yujyou":
                rarety = 2;
                bonusValue = 30;
                break;
            case "Akatuki":
                rarety = 3;
                bonusValue = 35;
                break;
            default:
                Debug.LogError("Illegal Value");
                break;
        }

        return new Artifact(series + "の指輪", color, rarety, "HP", bonusValue, series, image);
    }
}
