using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    MainGame mainGame;

    bool isPush;
    bool lateIsPush;
     
    [SerializeField] GameObject Character1;
    [SerializeField] GameObject Character2;
    [SerializeField] GameObject Character1UI;
    [SerializeField] GameObject Character1Skill1;
    [SerializeField] GameObject Character1Skill2;
    [SerializeField] GameObject Character1Skill3;
    [SerializeField] GameObject Character2UI;
    [SerializeField] GameObject Character2Skill1;
    [SerializeField] GameObject Character2Skill2;
    [SerializeField] GameObject Character2Skill3;
    [SerializeField] GameObject Pause;

    Button chara1;
    Button chara2;
    Button chara1UI;
    Button chara1Skill1;
    Button chara1Skill2;
    Button chara1Skill3;
    Button chara2UI;
    Button chara2Skill1;
    Button chara2Skill2;
    Button chara2Skill3;
    Button pause;

    Button[] buttons;
    Button[] activedButtons = new Button[11];

    List<string> enableButtonStack = new List<string>(0);

    // Start is called before the first frame update
    void Start()
    {
        mainGame = GetComponent<MainGame>();

        isPush = false;
        lateIsPush = false;

        chara1 = Character1.GetComponent<Button>();
        chara2 = Character2.GetComponent<Button>();
        chara1UI = Character1UI.GetComponent<Button>();
        chara1Skill1 = Character1Skill1.GetComponent<Button>();
        chara1Skill2 = Character1Skill2.GetComponent<Button>();
        chara1Skill3 = Character1Skill3.GetComponent<Button>();
        chara2UI = Character2UI.GetComponent<Button>();
        chara2Skill1 = Character2Skill1.GetComponent<Button>();
        chara2Skill2 = Character2Skill2.GetComponent<Button>();
        chara2Skill3 = Character2Skill3.GetComponent<Button>();
        pause = Pause.GetComponent<Button>();

        buttons = new Button[] { chara1, chara2, chara1UI, chara1Skill1, chara1Skill2, chara1Skill3, chara2UI, chara2Skill1, chara2Skill2, chara2Skill3, pause };
    }

    // Update is called once per frame
    void Update()
    {
        if(isPush == true && lateIsPush == false)
        {
            AllButtonDisable();
            lateIsPush = true;
        }
        if (enableButtonStack.Count > 0)
        {
            foreach (string name in enableButtonStack)
            {
                ButtoEnableByName(name);
            }
            enableButtonStack = new List<string>(0);
        }
    }

    //指定したボタンを無効にする
    internal void ButtonDisableByName(string name)
    {
        foreach (Button button in buttons)
        {
            if (button.ToString().Equals(name) == true)
            {
                button.interactable = false;
            }
        }
    }

    //指定したボタンを有効にする
    internal void ButtoEnableByName(string name)
    {
        if (isPush == false)
        {
            foreach (Button button in buttons)
            {
                if (button.ToString().Equals(name) == true)
                {
                    button.interactable = true;
                }
            }
        }
        else
        {
            //ボタン全体が無効の時後回しにする
            enableButtonStack.Add(name);
        }
    }

    //アクティブなボタンを無効にする
    void AllButtonDisable()
    {
        for (int i = 0; i < 11; i++)
        {
            if (buttons[i].interactable == true)
            {
                activedButtons[i] = buttons[i];
            }
        }
        foreach (Button button in activedButtons)
        {
            button.interactable = false;
        }
    }

    //無効にしたボタンを有効にする
    internal void AllButtonEnable()
    {
        isPush = false;
        lateIsPush = false;
        foreach (Button button in activedButtons)
        {
            button.interactable = true;
        }
        activedButtons = new Button[11];
    }

    public void onCharacter1UI()
    {
        isPush = true;
        mainGame.character1UI = true;
        ButtonDisableByName("Chara1UI");
    }

    public void onCharacter1Skill1()
    {
        mainGame.character1skil1 = true;
        ButtonDisableByName("Chara1Skill1");
    }

    public void onCharacter1Skill2()
    {
        mainGame.character1skil2 = true;
        ButtonDisableByName("Chara1Skill2");
    }

    public void onCharacter1Skill3()
    {
        mainGame.character1skil3 = true;
        ButtonDisableByName("Chara1Skill3");
    }

    public void onCharacter2UI()
    {
        isPush = true;
        mainGame.character2UI = true;
        ButtonDisableByName("Chara2UI");
    }

    public void onCharacter2Skill1()
    {
        mainGame.character2skil1 = true;
        ButtonDisableByName("Chara2Skill1");
    }

    public void onCharacter2Skill2()
    {
        mainGame.character2skil2 = true;
        ButtonDisableByName("Chara2Skill2");
    }

    public void onCharacter2Skill3()
    {
        mainGame.character2skil3 = true;
        ButtonDisableByName("Chara2Skill3");
    }

    public void onPause()
    {
        isPush = true;
        mainGame.pause = true;
    }

    public void onCharacter1()
    {
        isPush = true;
        mainGame.character1 = true;
        ButtonDisableByName("Chara1");
    }

    public void onCharacter2()
    {
        isPush = true;
        mainGame.character2 = true;
        ButtonDisableByName("Chara2");
    }
}
