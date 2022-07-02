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

    /*
    //座標変換
    Vector2 VectorConvert(Vector2 positionData)
    {
        float posx0 = positionData.x / 1;
        float posx1 = posx0 + 1;
        float posxFew = positionData.x % 1;
        float posy0 = positionData.y / 1;
        float posy1 = posy0 + 1;
        float posyFew = positionData.y % 1;
        float convertedposx0 = XConverter(posx1);

    }

    Vector2 XConverter(float posx)
    {
        Vector2 returnValue;
        if (posx >= 5)
        {

        }
        else
        {

        }


        return returnValue;
    } 
    */
}
