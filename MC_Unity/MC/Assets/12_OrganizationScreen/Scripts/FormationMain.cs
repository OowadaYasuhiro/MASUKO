using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormationMain : MonoBehaviour
{
    [SerializeField]
    private GameObject characterWindowLeft;
    [SerializeField]
    private GameObject characterWindowRight;
    [SerializeField]
    private GameObject selectWindow;

    private OrganizationScreen_Deta data = new OrganizationScreen_Deta();

    private Charactor chara;

    void Start()
    {
        DrawSelectUITexts();
        EraseSelectWindow();
        OrganizationScreen_Deta.isLeftCharacter = false;
        DrawCharacterUITextsAndImage();

        DrawArtifactsUI();
    }

    public void ShowSelectWindow()
    {
        selectWindow.SetActive(true);
        characterWindowLeft.SetActive(false);
        characterWindowRight.SetActive(false);
    }

    public void EraseSelectWindow()
    {
        selectWindow.SetActive(false);
        characterWindowLeft.SetActive(true);
        characterWindowRight.SetActive(true);

        DrawCharacterUITextsAndImage();
    }

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

    public void DrawCharacterUITextsAndImage()
    { 
        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            SetCharacterStruct(OrganizationScreen_Deta.leftCharacterNum);
            characterWindowLeft.transform.GetChild(1).GetComponent<Text>().text = chara.GetLevel().ToString();
            characterWindowLeft.transform.GetChild(2).GetComponent<Text>().text = chara.GetName();
            characterWindowLeft.transform.GetChild(8).GetComponent<Text>().text = chara.GetHp().ToString();
            characterWindowLeft.transform.GetChild(9).GetComponent<Text>().text = chara.GetAtk().ToString();
            characterWindowLeft.transform.GetChild(10).GetComponent<Text>().text = chara.GetDef().ToString();
            characterWindowLeft.transform.GetChild(12).GetComponent<Text>().text = chara.GetPassiveSkillName();
            characterWindowLeft.transform.GetChild(13).GetComponent<Text>().text = chara.GetPassiveSkillEffect();
        }
        else
        {
            if (OrganizationScreen_Deta.rightCharacterNum == -1)
            {
                characterWindowRight.transform.GetChild(1).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(2).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(8).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(9).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(10).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(12).GetComponent<Text>().text = "";
                characterWindowRight.transform.GetChild(13).GetComponent<Text>().text = "";
                Master.formationdeta.SetSelectCharacter2(null);
            }
            else
            {
                SetCharacterStruct(OrganizationScreen_Deta.rightCharacterNum);
                characterWindowRight.transform.GetChild(1).GetComponent<Text>().text = chara.GetLevel().ToString();
                characterWindowRight.transform.GetChild(2).GetComponent<Text>().text = chara.GetName();
                characterWindowRight.transform.GetChild(8).GetComponent<Text>().text = chara.GetHp().ToString();
                characterWindowRight.transform.GetChild(9).GetComponent<Text>().text = chara.GetAtk().ToString();
                characterWindowRight.transform.GetChild(10).GetComponent<Text>().text = chara.GetDef().ToString();
                characterWindowRight.transform.GetChild(12).GetComponent<Text>().text = chara.GetPassiveSkillName();
                characterWindowRight.transform.GetChild(13).GetComponent<Text>().text = chara.GetPassiveSkillEffect();
            }
        }

        characterWindowLeft.transform.GetChild(15).GetComponent<Text>().text = data.GetSynagySkills();
        characterWindowRight.transform.GetChild(15).GetComponent<Text>().text = data.GetSynagySkills();
    }

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

        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            Master.formationdeta.SetSelectCharacter1(chara);
        }
        else
        {
            Master.formationdeta.SetSelectCharacter2(chara);
        }
    }

    private void DrawArtifactsUI()
    {
        characterWindowLeft.transform.GetChild(17).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(0).GetColor();
        characterWindowLeft.transform.GetChild(18).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(1).GetColor();
        characterWindowLeft.transform.GetChild(19).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(2).GetColor(); 
        /*characterWindowRight.transform.GetChild(17).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(0).GetColor();
        characterWindowRight.transform.GetChild(18).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(1).GetColor();
        characterWindowRight.transform.GetChild(19).GetComponent<Image>().color = Master.formationdeta.GetCharactor1Artifact(2).GetColor();*/

        characterWindowLeft.transform.GetChild(17).GetComponentInChildren<Text>().text = Master.formationdeta.GetCharactor1Artifact(0).GetLevel().ToString();
        characterWindowLeft.transform.GetChild(18).GetComponentInChildren<Text>().text = Master.formationdeta.GetCharactor1Artifact(1).GetLevel().ToString();
        characterWindowLeft.transform.GetChild(19).GetComponentInChildren<Text>().text = Master.formationdeta.GetCharactor1Artifact(2).GetLevel().ToString();
    }
}
