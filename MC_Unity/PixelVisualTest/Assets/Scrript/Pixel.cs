using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pixel
{
    int _x;
    int _y;

    const byte air = 0;
    const byte rock = 1;
    const byte sand = 2;

    internal byte _type;

    bool _isStatic = false;

    int fallDelay = 60;
    int delayTime = 0;

    public Pixel(byte type)
    {
        _type = type;
        _isStatic = false;
    }

    public void UpData()
    {
        delayTime++;
        if (delayTime != fallDelay) goto SKIP;

        if (_isStatic) goto SKIP;

        

        SKIP:;
    }
}
