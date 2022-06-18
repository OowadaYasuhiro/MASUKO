using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGorund : MonoBehaviour
{

    //ステージ1背景
    [SerializeField] public Sprite stage1BackGround;
    //ステージ2背景
    [SerializeField] public Sprite stage2BackGround;
    //ステージ3背景
    [SerializeField] public Sprite stage3BackGround;
    //ステージ4背景
    [SerializeField] public Sprite stage4BackGround;
    //ステージ5背景
    [SerializeField] public Sprite stage5BackGround;

    internal void SetBackGround(int number)
    {
        Image image = GetComponent<Image>();
        switch (number)
        {
            case 1:
                image.sprite =  stage1BackGround;
                break;
            case 2:
                image.sprite = stage2BackGround;
                break;
            case 3:
                image.sprite = stage3BackGround;
                break;
            case 4:
                image.sprite = stage4BackGround;
                break;
            case 5:
                image.sprite = stage5BackGround;
                break;
        }
    }
}
