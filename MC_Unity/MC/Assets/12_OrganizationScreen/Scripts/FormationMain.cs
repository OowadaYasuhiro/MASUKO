using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FormationMain : MonoBehaviour
{
    /// <summary>
    /// 編成画面の処理
    /// </summary>

    [SerializeField]
    private GameObject characterWindowLeft;　
    [SerializeField]
    private GameObject characterWindowRight;
    [SerializeField]
    private GameObject selectWindow;
    [SerializeField]
    private GameObject alertWindow;
    [SerializeField]
    private Sprite defaultSprite;

    private OrganizationScreen_Deta data = new OrganizationScreen_Deta();

    private Charactor chara;

    private void Awake()
    {
        characterWindowLeft.transform.GetChild(17).GetComponentInChildren<Text>().text = "";
        characterWindowLeft.transform.GetChild(18).GetComponentInChildren<Text>().text = "";
        characterWindowLeft.transform.GetChild(19).GetComponentInChildren<Text>().text = "";
        characterWindowRight.transform.GetChild(17).GetComponentInChildren<Text>().text = "";
        characterWindowRight.transform.GetChild(18).GetComponentInChildren<Text>().text = "";
        characterWindowRight.transform.GetChild(19).GetComponentInChildren<Text>().text = "";

        this.alertWindow.SetActive(false);
    }

    void Start()
    {
        //初期状態のセット
        DrawSelectUITexts();
        EraseSelectWindow();
        OrganizationScreen_Deta.isLeftCharacter = false;
        DrawCharacterUITextsAndImage();
        OrganizationScreen_Deta.isLeftCharacter = true;
        DrawArtifactsUI();
    }

    public void ShowSelectWindow()
    {
        selectWindow.SetActive(true);
        characterWindowLeft.SetActive(false);
        characterWindowRight.SetActive(false);

        for (var i = 0; i < 5; i++)
        {
            selectWindow.transform.GetChild(i).GetComponent<Image>().color = Color.black;
            selectWindow.transform.GetChild(i).GetComponent<Button>().enabled = true;
        }

        if (!OrganizationScreen_Deta.isLeftCharacter)
        {
            int index = OrganizationScreen_Deta.leftCharacterNum;
            selectWindow.transform.GetChild(index).GetComponent<Image>().color = Color.gray;
            selectWindow.transform.GetChild(index).GetComponent<Button>().enabled = false;
        }
    }

    public void EraseSelectWindow()
    {
        selectWindow.SetActive(false);
        characterWindowLeft.SetActive(true);
        characterWindowRight.SetActive(true);

        DrawCharacterUITextsAndImage();
    }

    //hack: ポルターガイストの文字列
    private void DrawSelectUITexts()
    {
        selectWindow.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = data.ghost.GetName();
        selectWindow.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = "Lv" + data.ghost.GetLevel().ToString();
        selectWindow.transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = data.zasikiwarasi.GetName();
        selectWindow.transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = "Lv" + data.zasikiwarasi.GetLevel().ToString();
        selectWindow.transform.GetChild(2).transform.GetChild(0).GetComponent<Text>().text = data.ogre.GetName();
        selectWindow.transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = "Lv" + data.ogre.GetLevel().ToString();
        selectWindow.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "ポルター\nガイスト";
        selectWindow.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Lv" + data.poltergeist.GetLevel().ToString();
        selectWindow.transform.GetChild(4).transform.GetChild(0).GetComponent<Text>().text = data.demon.GetName();
        selectWindow.transform.GetChild(4).transform.GetChild(1).GetComponent<Text>().text = "Lv" + data.demon.GetLevel().ToString();
    }

    //todo キャラクター画像の設定
    //キャラクターウィンドウのテキストのロード
    public void DrawCharacterUITextsAndImage()
    { 
        int sumAtk = 0;
        int sumDef = 0;
        int sumHp = 0;
        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            //選択されたキャラクターのデータを取得
            SetCharacterStruct(OrganizationScreen_Deta.leftCharacterNum);

            for (var i = 0; i < 3; i++)
            {
                if (Master.formationdeta.GetCharactor1Artifact(i).GetName() != "noname")
                {
                    switch (Master.formationdeta.GetCharactor1Artifact(i).GetStaus())
                    {
                        case "ATK":
                            sumAtk += Master.formationdeta.GetCharactor1Artifact(i).GetAddValue();
                            break;
                        case "DEF":
                            sumDef += Master.formationdeta.GetCharactor1Artifact(i).GetAddValue();
                            break;
                        case "HP":
                            sumHp += Master.formationdeta.GetCharactor1Artifact(i).GetAddValue();
                            break;
                        default:
                            Debug.LogError("");
                            break;
                    }
                }
            }

            sumAtk += chara.GetAtk();
            sumDef += chara.GetDef();
            sumHp += chara.GetHp();

            if (Master.formationdeta.GetCharactor1Artifact(0).GetName() == "Onnnenの冠" &&
                Master.formationdeta.GetCharactor1Artifact(1).GetName() == "Onnnenの腕輪" &&
                Master.formationdeta.GetCharactor1Artifact(2).GetName() == "Onnnenの指輪")
            {
                sumAtk += RecoveryOfBelongingsScreen_Deta.bonusAtk;
            }
            else if (Master.formationdeta.GetCharactor1Artifact(0).GetName() == "Yujyouの冠" &&
                     Master.formationdeta.GetCharactor1Artifact(1).GetName() == "Yujyouの腕輪" &&
                     Master.formationdeta.GetCharactor1Artifact(2).GetName() == "Yujyouの指輪")
            {
                sumDef += RecoveryOfBelongingsScreen_Deta.bonusDef;
            }

            characterWindowLeft.transform.GetChild(1).GetComponent<Text>().text = chara.GetLevel().ToString();
            characterWindowLeft.transform.GetChild(2).GetComponent<Text>().text = chara.GetName();
            characterWindowLeft.transform.GetChild(8).GetComponent<Text>().text = sumHp.ToString();
            characterWindowLeft.transform.GetChild(9).GetComponent<Text>().text = sumAtk.ToString();
            characterWindowLeft.transform.GetChild(10).GetComponent<Text>().text = sumDef.ToString();
            characterWindowLeft.transform.GetChild(12).GetComponent<Text>().text = chara.GetPassiveSkillName();
            characterWindowLeft.transform.GetChild(13).GetComponent<Text>().text = chara.GetPassiveSkillEffect();
        }
        else //右のキャラクターウィンドウ
        {
            //何も選ばれていないときの処理
            if (OrganizationScreen_Deta.rightCharacterNum == -1)
            {
                characterWindowRight.transform.GetChild(1).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(2).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(8).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(9).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(10).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(12).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(13).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(17).GetComponent<Image>().color = Color.white;
                characterWindowRight.transform.GetChild(18).GetComponent<Image>().color = Color.white;
                characterWindowRight.transform.GetChild(19).GetComponent<Image>().color = Color.white;

                characterWindowRight.transform.GetChild(17).GetComponent<Image>().sprite = defaultSprite;
                characterWindowRight.transform.GetChild(18).GetComponent<Image>().sprite = defaultSprite;
                characterWindowRight.transform.GetChild(19).GetComponent<Image>().sprite = defaultSprite;

                characterWindowRight.transform.GetChild(17).GetComponentInChildren<Text>().text = "";
                characterWindowRight.transform.GetChild(18).GetComponentInChildren<Text>().text = "";
                characterWindowRight.transform.GetChild(19).GetComponentInChildren<Text>().text = "";

                ArmorNodeGeneretor.character2SelectedCrownNum = -1;
                ArmorNodeGeneretor.character2SelectedBangleNum = -1;
                ArmorNodeGeneretor.character2SelectedRingNum = -1;
                Master.formationdeta.SetSelectCharacter2(null);
            }
            else 
            {
                SetCharacterStruct(OrganizationScreen_Deta.rightCharacterNum);

                for (var i = 0; i < 3; i++)
                {
                    if (Master.formationdeta.GetCharactor2Artifact(i).GetName() != "noname")
                    {
                        switch (Master.formationdeta.GetCharactor2Artifact(i).GetStaus())
                        {
                            case "ATK":
                                sumAtk += Master.formationdeta.GetCharactor2Artifact(i).GetAddValue();
                                break;
                            case "DEF":
                                sumDef += Master.formationdeta.GetCharactor2Artifact(i).GetAddValue();
                                break;
                            case "HP":
                                sumHp += Master.formationdeta.GetCharactor2Artifact(i).GetAddValue();
                                break;
                            default:
                                Debug.LogError("");
                                break;
                        }
                    }
                }

                sumAtk += chara.GetAtk();
                sumDef += chara.GetDef();
                sumHp += chara.GetHp();

                if (Master.formationdeta.GetCharactor2Artifact(0).GetName() == "Onnnenの冠" &&
                    Master.formationdeta.GetCharactor2Artifact(1).GetName() == "Onnnenの腕輪" &&
                    Master.formationdeta.GetCharactor2Artifact(2).GetName() == "Onnnenの指輪")
                {
                    sumAtk += RecoveryOfBelongingsScreen_Deta.bonusAtk;
                }
                else if (Master.formationdeta.GetCharactor2Artifact(0).GetName() == "Yujyouの冠" &&
                         Master.formationdeta.GetCharactor2Artifact(1).GetName() == "Yujyouの腕輪" &&
                         Master.formationdeta.GetCharactor2Artifact(2).GetName() == "Yujyouの指輪")
                {
                    sumDef += RecoveryOfBelongingsScreen_Deta.bonusDef;
                }

                characterWindowRight.transform.GetChild(1).GetComponent<Text>().text = chara.GetLevel().ToString();
                characterWindowRight.transform.GetChild(2).GetComponent<Text>().text = chara.GetName();
                characterWindowRight.transform.GetChild(8).GetComponent<Text>().text = sumHp.ToString();
                characterWindowRight.transform.GetChild(9).GetComponent<Text>().text = sumAtk.ToString();
                characterWindowRight.transform.GetChild(10).GetComponent<Text>().text = sumDef.ToString();
                characterWindowRight.transform.GetChild(12).GetComponent<Text>().text = chara.GetPassiveSkillName();
                characterWindowRight.transform.GetChild(13).GetComponent<Text>().text = chara.GetPassiveSkillEffect();
            }
        }

        //シナジースキルの設定
        characterWindowLeft.transform.GetChild(15).GetComponent<Text>().text = data.GetSynagySkills();
        characterWindowRight.transform.GetChild(15).GetComponent<Text>().text = data.GetSynagySkills();
    }

    //対応するキャラクターの構造体のセット
    private void SetCharacterStruct(int charaNum)
    {
        switch (charaNum)
        {
            case 0:
                chara = data.ghost;
                break;
            case 1:
                chara = data.zasikiwarasi;
                break;
            case 2:
                chara = data.ogre;
                break;
            case 3:
                chara = data.poltergeist;
                break;
            case 4:
                chara = data.demon;
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }

        //セットされているキャラクターの保存
        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            Master.formationdeta.SetSelectCharacter1(chara);
        }
        else
        {
            Master.formationdeta.SetSelectCharacter2(chara);
        }
    }

    //遺物の反映を行う
    private void DrawArtifactsUI()
    {
        //todo 実際の画像が来たら削除
        characterWindowLeft.transform.GetChild(17).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(0).GetColor();
        characterWindowLeft.transform.GetChild(18).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(1).GetColor();
        characterWindowLeft.transform.GetChild(19).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(2).GetColor();

        //画像のセット
        characterWindowLeft.transform.GetChild(17).GetComponent<Image>().sprite = Master.formationdeta.GetCharactor1Artifact(0).GetIcon();
        characterWindowLeft.transform.GetChild(18).GetComponent<Image>().sprite = Master.formationdeta.GetCharactor1Artifact(1).GetIcon();
        characterWindowLeft.transform.GetChild(19).GetComponent<Image>().sprite = Master.formationdeta.GetCharactor1Artifact(2).GetIcon();

        //レベルのセット
        if (Master.formationdeta.GetCharactor1Artifact(0).GetName() != "noname")
        {
            characterWindowLeft.transform.GetChild(17).GetComponentInChildren<Text>().text = "Lv " + Master.formationdeta.GetCharactor1Artifact(0).GetLevel().ToString();
        } 
        if (Master.formationdeta.GetCharactor1Artifact(1).GetName() != "noname")
        {
            characterWindowLeft.transform.GetChild(18).GetComponentInChildren<Text>().text = "Lv " + Master.formationdeta.GetCharactor1Artifact(1).GetLevel().ToString();
        }
        if (Master.formationdeta.GetCharactor1Artifact(2).GetName() != "noname")
        {
            characterWindowLeft.transform.GetChild(19).GetComponentInChildren<Text>().text = "Lv " + Master.formationdeta.GetCharactor1Artifact(2).GetLevel().ToString();
        }
        
        if (Master.formationdeta.GetCharactor2() != null)
        {
            characterWindowRight.transform.GetChild(17).GetComponent<Image>().color = Master.formationdeta.GetCharactor2Artifact(0).GetColor();
            characterWindowRight.transform.GetChild(18).GetComponent<Image>().color = Master.formationdeta.GetCharactor2Artifact(1).GetColor();
            characterWindowRight.transform.GetChild(19).GetComponent<Image>().color = Master.formationdeta.GetCharactor2Artifact(2).GetColor();

            characterWindowRight.transform.GetChild(17).GetComponent<Image>().sprite = Master.formationdeta.GetCharactor2Artifact(0).GetIcon();
            characterWindowRight.transform.GetChild(18).GetComponent<Image>().sprite = Master.formationdeta.GetCharactor2Artifact(1).GetIcon();
            characterWindowRight.transform.GetChild(19).GetComponent<Image>().sprite = Master.formationdeta.GetCharactor2Artifact(2).GetIcon();

            if (Master.formationdeta.GetCharactor2Artifact(0).GetName() != "noname")
            {
                characterWindowRight.transform.GetChild(17).GetComponentInChildren<Text>().text = "Lv " + Master.formationdeta.GetCharactor2Artifact(0).GetLevel().ToString();
            }
            if (Master.formationdeta.GetCharactor2Artifact(1).GetName() != "noname")
            {
                characterWindowRight.transform.GetChild(18).GetComponentInChildren<Text>().text = "Lv " + Master.formationdeta.GetCharactor2Artifact(1).GetLevel().ToString();
            }
            if (Master.formationdeta.GetCharactor2Artifact(2).GetName() != "noname")
            {
                characterWindowRight.transform.GetChild(19).GetComponentInChildren<Text>().text = "Lv " + Master.formationdeta.GetCharactor2Artifact(2).GetLevel().ToString();
            }
        }
    }

    public void ShowAlertWindow()
    {
        alertWindow.SetActive(true);
    }
}
