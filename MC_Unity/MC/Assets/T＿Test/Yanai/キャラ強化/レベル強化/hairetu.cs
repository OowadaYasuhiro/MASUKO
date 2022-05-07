using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hairetu : MonoBehaviour
{
    //デーモン
    public static int[] DEmonHP = new int[91];
    public static int[] DEmonAtk = new int[91];
    public static int[] DEmonDef = new int[91];
    //ポルターガイスト
    public static int[] PorutaHP = new int[91];
    public static int[] PorutaAtk = new int[91];
    public static int[] PorutaDef = new int[91];
    //鬼
    public static int[] GoreHP = new int[91];
    public static int[] GoreAtk = new int[91];
    public static int[] GoreDef = new int[91];
    //座敷童
    public static int[] ZasikiHP = new int[91];
    public static int[] ZasikiAtk = new int[91];
    public static int[] ZasikiDef = new int[91];
    //幽霊
    public static int[] GhostHP = new int[91];
    public static int[] GhostAtk = new int[91];
    public static int[] GhostDef = new int[91];
    // Start is called before the first frame update
    void Start()
    {
        //デーモン


        // Update is called once per frame
        for (int i = 1; i <= 50; i++)
        {
            DEmonHP[i] = 450 + (i * 3);
            DEmonAtk[i] = 140 + i * 3;
            DEmonDef[i] = 60 + (int)(0.6 * i);
        }
        for (int i = 51; i <= 90; i++)
        {
            DEmonHP[i] = 600 + i * 15;
            DEmonAtk[i] = 290 + (int)(4.75 * i);
            DEmonDef[i] = 90 + (int)(1.25 * i);
        }
        //ポルターガイスト
        for (int i = 1; i <= 50; i++)
        {
            PorutaHP[i] = 520 + (int)(i * 6.6);
            PorutaAtk[i] = 110 + (int)(i * 2.6);
            PorutaDef[i] = 75 + (int)(0.5 * i);
        }
        for (int i = 51; i <= 90; i++)
        {
            PorutaHP[i] = 850 + (int)(18.75 * i);
            PorutaAtk[i] = 240 + (int)(3.5 * i);
            PorutaDef[i] = 100 + (int)(1.25 * i);
        }
        //鬼
        for (int i = 1; i <= 50; i++)
        {
            GoreHP[i] = 750 + (i * 11);
            GoreAtk[i] = 50 + i;
            GoreDef[i] = 120 + (2 * i);
        }
        for (int i = 51; i <= 90; i++)
        {
            GoreHP[i] = 1300 + (int)(32.5 * i);
            GoreAtk[i] = 100 + (int)(3.75 * i);
            GoreDef[i] = 220 + (int)(2.5 * i);
        }
        //座敷童
        for (int i = 1; i <= 50; i++)
        {
            ZasikiHP[i] = 700 + (i * 12);
            ZasikiAtk[i] = 100 + i;
            ZasikiDef[i] = 150 + (2 * i);
        }
        for (int i = 51; i <= 90; i++)
        {
            ZasikiHP[i] = 1300 + (int)(17.5 * i);
            ZasikiAtk[i] = 150 + (int)(1.25 * i);
            ZasikiDef[i] = 250 + (int)(3.75 * i);
        }
        //ゴースト
        for (int i = 1; i <= 50; i++)
        {
            GhostHP[i] = 500 + (i * 5);
            GhostAtk[i] = 120 + (i * 3);
            GhostDef[i] = 70 + i;
        }
        for (int i = 51; i <= 90; i++)
        {
            GhostHP[i] = 750 + (int)(6.25 * i);
            GhostAtk[i] = 270 + (int)(3.75 * i);
            GhostDef[i] = 120 + i;
        }
    }
}
