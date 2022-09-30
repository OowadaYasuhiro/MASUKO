using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionConvert : MonoBehaviour
{

    //グリッドの高さ(rectTransform)
    const float depth0 = 306;
    const float depth1 = 200;
    const float depth2 = 88;
    const float depth3 = -30;
    const float depth4 = -150;
    const float depth5 = -278;

    //横(±左右)
    const float depth01 = 79;

    //上がり幅初期値
    const float addWidth = 154;
    //
    const float farstDown = 2;
    //
    const float nextAdd = 3;
    //
    const float correctionWidth = 0.1f;

    //座標変換
    static public Vector2 VectorConvert(Vector2 positionData)
    {
        float posx0 = positionData.x / 1;
        float posx1 = posx0 + 1;
        float posxFew = positionData.x % 1;
        float posy0 = positionData.y / 1;
        float posy1 = posy0 + 1;
        float posyFew = positionData.y % 1;
        float convertedposx0 = XConverter(posx0, posy0);
        float convertedposx1 = XConverter(posx1, posy0);
        float convertedposy0 = YConverter(posy0);
        float convertedposy1 = YConverter(posy1);
        Vector2 returnValue = new Vector2();
        returnValue.x = convertedposx0 + ((convertedposx1 - convertedposx0) * (posxFew / 100f));
        returnValue.y = convertedposy0 + ((convertedposy1 - convertedposy0) * posyFew);
        return returnValue;
    }

    static float XConverter(float posx,float posy)
    {
        float returnValue;
        if (posx >= 5)
        {
            if (posx == 5)
            {
                returnValue = depth01 + (5f - posy) + correctionWidth * (5f - posy);
            }
            else
            {
                returnValue = depth01 + (5f - posy) + ((addWidth + correctionWidth * (5f - posy)) +(nextAdd * (5f - posy)) + (((addWidth + correctionWidth * (5f - posy)) + (nextAdd * (5f - posy)) - farstDown) * (posx - 6)));
            }
            
        }
        else
        {
            if (posx == 4)
            {
                returnValue = -(depth01 + (5f - posy)) + correctionWidth * (5f - posy);
            }
            else
            {
                returnValue = depth01 + (5f - posy) - ((addWidth + correctionWidth * (5f - posy)) + (nextAdd * (5f - posy)) + (((addWidth + correctionWidth * (5f - posy)) + (nextAdd * (5f - posy)) - farstDown) * (4 - posx)));
            }
        }
        return returnValue;
    } 

    static float YConverter(float posy)
    {
        float returnValue = 0;
        switch (posy)
        {
            case 0:
                returnValue = depth5;
                break;
            case 1:
                returnValue = depth4;
                break;
            case 2:
                returnValue = depth3;
                break;
            case 3:
                returnValue = depth2;
                break;
            case 4:
                returnValue = depth1;
                break;
            case 5:
                returnValue = depth0;
                break;
        }
        return returnValue;
    }
}
