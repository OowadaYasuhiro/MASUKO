using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[Serializable]
public class MainGame_StageUI : MonoBehaviour
{
    [Space(15)]
    //背景
    [SerializeField] public GameObject backGround;
    //ステージ
    [SerializeField] public GameObject stage;
    //壁オブジェクト
    [SerializeField] public GameObject[] obstacle;
}
