using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    MainGame mainGame;

    bool isPush;
    // Start is called before the first frame update
    void Start()
    {
        mainGame = GetComponent<MainGame>();
        isPush = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ボタンを無効にする
    void ButtonDisable()
    {

    }

    //ボタンを有効にする
    void ButtonEnable()
    {

    }

    public void onCharacter1UI()
    {
        mainGame.character1UI = true;
    }

    public void onCharacter1Skill1()
    {
        mainGame.character1skil1 = true;
    }

    public void onCharacter1Skill2()
    {
        mainGame.character1skil2 = true;
    }

    public void onCharacter1Skill3()
    {
        mainGame.character1skil3 = true;
    }

    public void onCharacter2UI()
    {
        mainGame.character2UI = true;
    }

    public void onCharacter2Skill1()
    {
        mainGame.character2skil1 = true;
    }

    public void onCharacter2Skill2()
    {
        mainGame.character2skil2 = true;
    }

    public void onCharacter2Skill3()
    {
        mainGame.character2skil3 = true;
    }

    public void onPause()
    {
        mainGame.pause = true;
    }

    public void onCharacter1()
    {
        mainGame.character1 = true;
    }

    public void onCharacter2()
    {
        mainGame.character2 = true;
    }
}
