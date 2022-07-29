using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using static MainGameCharacterState;
using static Constant;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    GameObject Player1;
    [SerializeField]
    GameObject Player2;
    [SerializeField]
    GameObject Enemy1;
    [SerializeField]
    GameObject Enemy2;

    RectTransform player1Rect;
    RectTransform player2Rect;
    RectTransform enemy1Rect;
    RectTransform enemy2Rect;

    Vector2 outPosition = new Vector2(-1,-1);
    Vector2 outSide = new Vector2(20,0);

    HpSlider player1HpSlider;
    HpSlider player2HpSlider;

    SkeletonAnimation player1Animation;
    SkeletonAnimation player2Animation;
    SkeletonAnimation enemy1Animation;
    SkeletonAnimation enemy2Animation;

    [SerializeField]
    GameObject[] Player1Spine;
    [SerializeField]
    GameObject[] Player2Spine;
    [SerializeField]
    GameObject[] Enemy1Spine;
    [SerializeField]
    GameObject[] Enemy2Spine;

    MainGame mainGame;

    private void Start()
    {
        player1Rect = Player1.GetComponent<RectTransform>();
        player2Rect = Player2.GetComponent<RectTransform>();
        enemy1Rect = Enemy1.GetComponent<RectTransform>();
        enemy2Rect = Enemy2.GetComponent<RectTransform>();
        player1HpSlider = Player1.GetComponentInChildren<HpSlider>();
        player2HpSlider = Player2.GetComponentInChildren<HpSlider>();
        mainGame = GetComponent<MainGame>();
        CharaReLoad();
    }

    internal void CharaReLoad()
    {
        for (int i = 0; i < Player1Spine.Length; i++)
        {
            Player1Spine[i].SetActive(false);
            Player2Spine[i].SetActive(false);
        }
        for (int i = 0; i < Enemy1Spine.Length; i++)
        {
            Enemy1Spine[i].SetActive(false);
            Enemy2Spine[i].SetActive(false);
        }
        for (int i = 0; i < mainGame.players.Length; i++)
        {
            switch (mainGame.players[i].GetName())
            {
                case Daemon:
                    if (i == 0)
                    {
                        player1Animation = Player1Spine[0].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player1Spine.Length; j++)
                        {
                            if (j != 0)
                            {
                                Player1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        player2Animation = Player2Spine[0].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player2Spine.Length; j++)
                        {
                            if (j != 0)
                            {
                                Player2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Ghost:
                    if (i == 0)
                    {
                        player1Animation = Player1Spine[1].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player1Spine.Length; j++)
                        {
                            if (j != 1)
                            {
                                Player1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        player2Animation = Player2Spine[1].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player2Spine.Length; j++)
                        {
                            if (j != 1)
                            {
                                Player2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Gore:
                    if (i == 0)
                    {
                        player1Animation = Player1Spine[2].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player1Spine.Length; j++)
                        {
                            if (j != 2)
                            {
                                Player1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        player2Animation = Player2Spine[2].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player2Spine.Length; j++)
                        {
                            if (j != 2)
                            {
                                Player2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Poltergeist:
                    if (i == 0)
                    {
                        player1Animation = Player1Spine[3].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player1Spine.Length; j++)
                        {
                            if (j != 3)
                            {
                                Player1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        player2Animation = Player2Spine[3].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player2Spine.Length; j++)
                        {
                            if (j != 3)
                            {
                                Player2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Zashiki_warashi:
                    if (i == 0)
                    {
                        player1Animation = Player1Spine[4].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player1Spine.Length; j++)
                        {
                            if (j != 4)
                            {
                                Player1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        player2Animation = Player2Spine[4].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Player2Spine.Length; j++)
                        {
                            if (j != 4)
                            {
                                Player2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Player2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
            }
        }
        for (int i = 0; i < mainGame.enemies.Length; i++)
        {
            switch (mainGame.enemies[i].GetName())
            {
                case Koisurugyaru:
                    if (i == 0)
                    {
                        enemy1Animation = Enemy1Spine[0].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy1Spine.Length; j++)
                        {
                            if (j != 0)
                            {
                                Enemy1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        enemy2Animation = Enemy2Spine[0].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy2Spine.Length; j++)
                        {
                            if (j != 0)
                            {
                                Enemy2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Kowamoteyanki:
                    if (i == 0)
                    {
                        enemy1Animation = Enemy1Spine[1].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy1Spine.Length; j++)
                        {
                            if (j != 1)
                            {
                                Enemy1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        enemy2Animation = Enemy2Spine[1].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy2Spine.Length; j++)
                        {
                            if (j != 1)
                            {
                                Enemy2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Namaikinasyouzyo:
                    if (i == 0)
                    {
                        enemy1Animation = Enemy1Spine[2].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy1Spine.Length; j++)
                        {
                            if (j != 2)
                            {
                                Enemy1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        enemy2Animation = Enemy2Spine[2].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy2Spine.Length; j++)
                        {
                            if (j != 2)
                            {
                                Enemy2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Piekin:
                    if (i == 0)
                    {
                        enemy1Animation = Enemy1Spine[3].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy1Spine.Length; j++)
                        {
                            if (j != 3)
                            {
                                Enemy1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        enemy2Animation = Enemy2Spine[3].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy2Spine.Length; j++)
                        {
                            if (j != 3)
                            {
                                Enemy2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Piennnaonnnanoko:
                    if (i == 0)
                    {
                        enemy1Animation = Enemy1Spine[4].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy1Spine.Length; j++)
                        {
                            if (j != 4)
                            {
                                Enemy1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        enemy2Animation = Enemy2Spine[4].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy2Spine.Length; j++)
                        {
                            if (j != 4)
                            {
                                Enemy2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
                case Tuyogarisyounen:
                    if (i == 0)
                    {
                        enemy1Animation = Enemy1Spine[5].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy1Spine.Length; j++)
                        {
                            if (j != 5)
                            {
                                Enemy1Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy1Spine[j].SetActive(true);
                            }
                        }
                    }
                    else
                    {
                        enemy2Animation = Enemy2Spine[5].GetComponent<SkeletonAnimation>();
                        for (int j = 0; j < Enemy2Spine.Length; j++)
                        {
                            if (j != 5)
                            {
                                Enemy2Spine[j].SetActive(false);
                            }
                            else
                            {
                                Enemy2Spine[j].SetActive(true);
                            }
                        }
                    }
                    break;
            }
        }
    }

    public void CharacterVisualization(Vector2 position,bool player,int number)
    {
        if (position == outPosition)
        {
            if (player == true)
            {
                if (number == 1)
                {
                    player1Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
                else
                {
                    player2Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
            }
            else
            {
                if (number == 1)
                {
                    enemy1Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
                else
                {
                    enemy2Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
            }
        }
        else
        {
            if (player == true)
            {
                if (number == 1)
                {
                    player1Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
                else
                {
                    player2Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
            }
            else
            {
                if (number == 1)
                {
                    enemy1Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
                else
                {
                    enemy2Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
            }
        }
    }

    internal void SetCharacterHpSlider(int number,int hp,int maxHp)
    {
        if (number == 1)
        {
            player1HpSlider.SetHpSlider(hp,maxHp);
        }
        else
        {
            player2HpSlider.SetHpSlider(hp, maxHp);
        }
    }

    internal void CharacterAnimation(bool player,int number, CharacterAnimState characterAnimState,string name,bool takeDamage)
    {
        if (takeDamage == true)
        {
            if (number == 1)
            {
                if (name.Equals(Koisurugyaru) == true)
                {
                    enemy1Animation.AnimationName = "kyougekiukeru";
                    enemy1Animation.timeScale = 1;
                }
                else if (name.Equals(Tuyogarisyounen) == true)
                {
                    enemy1Animation.AnimationName = "got attack";
                    enemy1Animation.timeScale = 1;
                }
                else
                {
                    enemy1Animation.AnimationName = "got damage";
                    enemy1Animation.timeScale = 1;
                }
            }
            else
            {
                if (name.Equals(Koisurugyaru) == true)
                {
                    enemy2Animation.AnimationName = "kyougekiukeru";
                    enemy2Animation.timeScale = 1;
                }
                else if (name.Equals(Tuyogarisyounen) == true)
                {
                    enemy2Animation.AnimationName = "got attack";
                    enemy2Animation.timeScale = 1;
                }
                else
                {
                    enemy2Animation.AnimationName = "got damage";
                    enemy2Animation.timeScale = 1;
                }
            }
        }
        else
        {
            if (player == true)
            {
                if (number == 1)
                {
                    switch (characterAnimState)
                    {
                        case CharacterAnimState.Fight:
                            player1Animation.AnimationName = "attack";
                            break;
                        case CharacterAnimState.Wait:
                            player1Animation.AnimationName = "idring";
                            break;
                        case CharacterAnimState.Lose:
                            player1Animation.AnimationName = "lose";
                            break;
                        case CharacterAnimState.Win:
                            player1Animation.AnimationName = "win";
                            break;
                    }
                }
                else
                {
                    switch (characterAnimState)
                    {
                        case CharacterAnimState.Fight:
                            player2Animation.AnimationName = "attack";
                            break;
                        case CharacterAnimState.Wait:
                            player2Animation.AnimationName = "idring";
                            break;
                        case CharacterAnimState.Lose:
                            player2Animation.AnimationName = "lose";
                            break;
                        case CharacterAnimState.Win:
                            player2Animation.AnimationName = "win";
                            break;
                    }
                }
            }
            else
            {
                if (number == 1)
                {
                    switch (characterAnimState)
                    {
                        case CharacterAnimState.Wait:
                            if (name.Equals(Koisurugyaru) == true)
                            {
                                enemy1Animation.AnimationName = "taiki";
                                enemy1Animation.timeScale = 1;
                            }
                            else
                            {
                                enemy1Animation.AnimationName = "idring";
                                enemy1Animation.timeScale = 1;
                            }
                            break;
                        case CharacterAnimState.Run:
                            if (name.Equals(Namaikinasyouzyo) == true)
                            {
                                enemy1Animation.AnimationName = "waljk";
                                enemy1Animation.timeScale = 1.7f;
                            }
                            else
                            {
                                enemy1Animation.AnimationName = "walk";
                                enemy1Animation.timeScale = 1.7f;
                            }
                            break;
                        case CharacterAnimState.Die:
                            if (name.Equals(Koisurugyaru) == true)
                            {
                                enemy1Animation.AnimationName = "sibou";
                                enemy1Animation.timeScale = 1;
                            }
                            else
                            {
                                enemy1Animation.AnimationName = "dead";
                                enemy1Animation.timeScale = 1;
                            }
                            break;
                        case CharacterAnimState.Fight:
                            if (name.Equals(Koisurugyaru) == true)
                            {
                                enemy1Animation.AnimationName = "kyougeki";
                                enemy1Animation.timeScale = 1;
                            }
                            else
                            {
                                enemy1Animation.AnimationName = "attack";
                                enemy1Animation.timeScale = 1;
                            }
                            break;
                    }
                }
                else
                {
                    switch (characterAnimState)
                    {
                        case CharacterAnimState.Wait:
                            if (name.Equals(Koisurugyaru) == true)
                            {
                                enemy2Animation.AnimationName = "taiki";
                                enemy2Animation.timeScale = 1;
                            }
                            else
                            {
                                enemy2Animation.AnimationName = "idring";
                                enemy2Animation.timeScale = 1;
                            }
                            break;
                        case CharacterAnimState.Run:
                            if (name.Equals(Namaikinasyouzyo) == true)
                            {
                                enemy2Animation.AnimationName = "waljk";
                                enemy2Animation.timeScale = 1.7f;
                            }
                            else
                            {
                                enemy2Animation.AnimationName = "walk";
                                enemy2Animation.timeScale = 1.7f;
                            }
                            break;
                        case CharacterAnimState.Die:
                            if (name.Equals(Koisurugyaru) == true)
                            {
                                enemy2Animation.AnimationName = "sibou";
                                enemy2Animation.timeScale = 1;
                            }
                            else
                            {
                                enemy2Animation.AnimationName = "dead";
                                enemy2Animation.timeScale = 1;
                            }
                            break;
                        case CharacterAnimState.Fight:
                            if (name.Equals(Koisurugyaru) == true)
                            {
                                enemy2Animation.AnimationName = "kyougeki";
                                enemy2Animation.timeScale = 1;
                            }
                            else
                            {
                                enemy2Animation.AnimationName = "attack";
                                enemy2Animation.timeScale = 1;
                            }
                            break;
                    }
                }
            }
        }
    }

    internal void SetCharacterDirection(bool player, int number,bool right)
    {
        if (player == true)
        {
            if (number == 1)
            {
                if (right == true)
                {

                }
                else
                {

                }
            }
            else
            {
                if (right == true)
                {

                }
                else
                {

                }
            }
        }
        else
        {
            if (number == 1)
            {
                if (right == true)
                {
                    enemy1Rect.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    enemy1Rect.localScale = new Vector3(-1, 1, 1);
                }
            }
            else
            {
                if (right == true)
                {

                }
                else
                {

                }
            }
        }
    }
}
