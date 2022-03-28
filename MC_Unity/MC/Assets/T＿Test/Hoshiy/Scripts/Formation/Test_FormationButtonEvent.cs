using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test_FormationButtonEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject characterWindow1;
    [SerializeField]
    private GameObject characterWindow2;
    [SerializeField]
    private GameObject characterSelectUi;
    [SerializeField]
    private GameObject armorSelectUi;

    private bool isWindow1;

    private int window1CharacterNum = 0;
    private int window2CharacterNum = 1;

    private int armorPositionNum;
    private Color armorColor;

    void Start()
    {
        isWindow1 = true;
        SetCharacterImage(window1CharacterNum);
        SetCharacterStatus(window1CharacterNum, characterWindow1);
        isWindow1 = false;
        SetCharacterImage(window2CharacterNum);
        SetCharacterStatus(window2CharacterNum, characterWindow2);

        characterWindow1.SetActive(true);
        characterWindow2.SetActive(true);
        characterSelectUi.SetActive(false);
        armorSelectUi.SetActive(false);
    }

    public void OnClickBackButton()
    {
        SceneManager.LoadScene("Hoshiy_TestScene");
    }

    public void OnClickCharacterImage(bool isWindow1)
    {
        this.isWindow1 = isWindow1;

        characterWindow1.SetActive(false);
        characterWindow2.SetActive(false);
        characterSelectUi.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        characterWindow1.SetActive(true);
        characterWindow2.SetActive(true);

        if (isWindow1 && index == window2CharacterNum)
        {
            window2CharacterNum = window1CharacterNum;
            SetCharacterImage(index);
            SetCharacterStatus(index, characterWindow1);
            isWindow1 = false;
            SetCharacterImage(window2CharacterNum);
            SetCharacterStatus(window2CharacterNum, characterWindow2);
        } 
        else if (!isWindow1 && index == window1CharacterNum)
        {
            window1CharacterNum = window2CharacterNum;
            SetCharacterImage(index);
            SetCharacterStatus(index, characterWindow2);
            isWindow1 = true;
            SetCharacterImage(window1CharacterNum);
            SetCharacterStatus(window1CharacterNum, characterWindow1);
        }
        else if (isWindow1 && index == window1CharacterNum && window2CharacterNum != -1)
        {
            window1CharacterNum = window2CharacterNum;
            SetCharacterImage(window1CharacterNum);
            SetCharacterStatus(window1CharacterNum, characterWindow1);
            isWindow1 = false;
            SetCharacterImage(-1);
            SetCharacterStatus(-1, characterWindow2);
        } else if (!isWindow1 && index == window2CharacterNum)
        {
            SetCharacterImage(-1);
            SetCharacterStatus(-1, characterWindow2);
        } 
        else
        {
            SetCharacterImage(index);

            if (isWindow1)
            {
                SetCharacterStatus(index, characterWindow1);
            }
            else
            {
                SetCharacterStatus(index, characterWindow2);
            }
        }

        characterSelectUi.SetActive(false);
        Hy_Test_Data.imageNum = window1CharacterNum;
    }

    public void OnClickArmorButton(int index)
    {
        armorPositionNum = index;
        characterWindow1.SetActive(false);
        characterWindow2.SetActive(false);
        armorSelectUi.SetActive(true);
        ReferenceArmorData();
    }

    public void OnClickSelectArmor(int index)
    {
        characterWindow1.SetActive(true);
        characterWindow2.SetActive(true);

        switch (index)
        {
            case 0:
                armorColor = Color.red;
                break;
            case 1:
                armorColor = Color.blue;
                break;
            case 2:
                armorColor = Color.green;
                break;
            case 3:
                armorColor = Color.yellow;
                break;
            case 4:
                armorColor = Color.magenta;
                break;
            case 5:
                armorColor = Color.white;
                break;
            default:
                Debug.Log("Error");
                break;
        }
        SetArmorImage(armorPositionNum, armorColor);

        armorSelectUi.SetActive(false);
    }

    private void ReferenceArmorData()
    {
        armorSelectUi.transform.GetChild(1).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[0].ToString();
        armorSelectUi.transform.GetChild(2).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[1].ToString();
        armorSelectUi.transform.GetChild(3).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[2].ToString();
        armorSelectUi.transform.GetChild(4).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[3].ToString();
        armorSelectUi.transform.GetChild(5).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[4].ToString();
        armorSelectUi.transform.GetChild(6).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[5].ToString();
    }

    private void SetArmorImage(int armorPos,Color color)
    {
        switch (armorPos)
        {
            case 0:
                characterWindow1.transform.GetChild(17).GetComponent<Image>().color = color;
                characterWindow1.transform.GetChild(17).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[0].ToString();
                break;
            case 1:
                characterWindow1.transform.GetChild(18).GetComponent<Image>().color = color;
                characterWindow1.transform.GetChild(18).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[1].ToString();
                break;
            case 2:
                characterWindow1.transform.GetChild(19).GetComponent<Image>().color = color;
                characterWindow1.transform.GetChild(19).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[2].ToString();
                break;
            case 3:
                characterWindow2.transform.GetChild(17).GetComponent<Image>().color = color;
                characterWindow2.transform.GetChild(17).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[3].ToString();
                break;
            case 4:
                characterWindow2.transform.GetChild(18).GetComponent<Image>().color = color;
                characterWindow2.transform.GetChild(18).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[4].ToString();
                break;
            case 5:
                characterWindow2.transform.GetChild(19).GetComponent<Image>().color = color;
                characterWindow2.transform.GetChild(19).GetComponentInChildren<Text>().text = "Lv" + Hy_Test_Data.armorLevels[5].ToString();
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }

    private void SetCharacterImage(int index)
    {
        switch (index)
        {
            case 0:
                if (isWindow1) { 
                    characterWindow1.transform.GetChild(3).GetComponent<Image>().color = Color.red;
                    window1CharacterNum = 0;
                }
                else { 
                    characterWindow2.transform.GetChild(3).GetComponent<Image>().color = Color.red;
                    window2CharacterNum = 0;
                }
                break;
            case 1:
                if (isWindow1) { 
                    characterWindow1.transform.GetChild(3).GetComponent<Image>().color = Color.blue;
                    window1CharacterNum = 1;
                }
                else { 
                    characterWindow2.transform.GetChild(3).GetComponent<Image>().color = Color.blue;
                    window2CharacterNum = 1;
                }
                break;
            case 2:
                if (isWindow1) { 
                    characterWindow1.transform.GetChild(3).GetComponent<Image>().color = Color.green;
                    window1CharacterNum = 2;
                }
                else { 
                    characterWindow2.transform.GetChild(3).GetComponent<Image>().color = Color.green;
                    window2CharacterNum = 2;
                }
                break;
            case 3:
                if (isWindow1) { 
                    characterWindow1.transform.GetChild(3).GetComponent<Image>().color = Color.yellow;
                    window1CharacterNum = 3;
                }
                else { 
                    characterWindow2.transform.GetChild(3).GetComponent<Image>().color = Color.yellow;
                    window2CharacterNum = 3;
                }
                break;
            case 4:
                if (isWindow1) { 
                    characterWindow1.transform.GetChild(3).GetComponent<Image>().color = Color.magenta;
                    window1CharacterNum = 4;
                }
                else { 
                    characterWindow2.transform.GetChild(3).GetComponent<Image>().color = Color.magenta;
                    window2CharacterNum = 4;
                }
                break;
            default:
                    characterWindow2.transform.GetChild(3).GetComponent<Image>().color = Color.white;
                    window2CharacterNum = -1;
                break;
        }
    }

    private void SetCharacterStatus(int characterNum,GameObject characterWindow)
    {
        switch (characterNum) {
            case 0:
                characterWindow.transform.GetChild(1).GetComponent<Text>().text = Hy_Test_Data.character1Level.ToString();
                characterWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.character1Name;
                characterWindow.transform.GetChild(8).GetComponent<Text>().text = Hy_Test_Data.character1Hp.ToString();
                characterWindow.transform.GetChild(9).GetComponent<Text>().text = Hy_Test_Data.character1Atk.ToString();
                characterWindow.transform.GetChild(10).GetComponent<Text>().text = Hy_Test_Data.character1Def.ToString();
                characterWindow.transform.GetChild(12).GetComponent<Text>().text = Hy_Test_Data.character1PassiveSkill;
                characterWindow.transform.GetChild(13).GetComponent<Text>().text = Hy_Test_Data.character1PassiveEffect;
                break;
            case 1:
                characterWindow.transform.GetChild(1).GetComponent<Text>().text = Hy_Test_Data.character2Level.ToString();
                characterWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.character2Name;
                characterWindow.transform.GetChild(8).GetComponent<Text>().text = Hy_Test_Data.character2Hp.ToString();
                characterWindow.transform.GetChild(9).GetComponent<Text>().text = Hy_Test_Data.character2Atk.ToString();
                characterWindow.transform.GetChild(10).GetComponent<Text>().text = Hy_Test_Data.character2Def.ToString();
                characterWindow.transform.GetChild(12).GetComponent<Text>().text = Hy_Test_Data.character2PassiveSkill;
                characterWindow.transform.GetChild(13).GetComponent<Text>().text = Hy_Test_Data.character2PassiveEffect;
                break;
            case 2:
                characterWindow.transform.GetChild(1).GetComponent<Text>().text = Hy_Test_Data.character3Level.ToString();
                characterWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.character3Name;
                characterWindow.transform.GetChild(8).GetComponent<Text>().text = Hy_Test_Data.character3Hp.ToString();
                characterWindow.transform.GetChild(9).GetComponent<Text>().text = Hy_Test_Data.character3Atk.ToString();
                characterWindow.transform.GetChild(10).GetComponent<Text>().text = Hy_Test_Data.character3Def.ToString();
                characterWindow.transform.GetChild(12).GetComponent<Text>().text = Hy_Test_Data.character3PassiveSkill;
                characterWindow.transform.GetChild(13).GetComponent<Text>().text = Hy_Test_Data.character3PassiveEffect;
                break;
            case 3:
                characterWindow.transform.GetChild(1).GetComponent<Text>().text = Hy_Test_Data.character4Level.ToString();
                characterWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.character4Name;
                characterWindow.transform.GetChild(8).GetComponent<Text>().text = Hy_Test_Data.character4Hp.ToString();
                characterWindow.transform.GetChild(9).GetComponent<Text>().text = Hy_Test_Data.character4Atk.ToString();
                characterWindow.transform.GetChild(10).GetComponent<Text>().text = Hy_Test_Data.character4Def.ToString();
                characterWindow.transform.GetChild(12).GetComponent<Text>().text = Hy_Test_Data.character4PassiveSkill;
                characterWindow.transform.GetChild(13).GetComponent<Text>().text = Hy_Test_Data.character4PassiveEffect;
                break;
            case 4:
                characterWindow.transform.GetChild(1).GetComponent<Text>().text = Hy_Test_Data.character5Level.ToString();
                characterWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.character5Name;
                characterWindow.transform.GetChild(8).GetComponent<Text>().text = Hy_Test_Data.character5Hp.ToString();
                characterWindow.transform.GetChild(9).GetComponent<Text>().text = Hy_Test_Data.character5Atk.ToString();
                characterWindow.transform.GetChild(10).GetComponent<Text>().text = Hy_Test_Data.character5Def.ToString();
                characterWindow.transform.GetChild(12).GetComponent<Text>().text = Hy_Test_Data.character5PassiveSkill;
                characterWindow.transform.GetChild(13).GetComponent<Text>().text = Hy_Test_Data.character5PassiveEffect;
                break;
            default:
                characterWindow.transform.GetChild(1).GetComponent<Text>().text = "0";
                characterWindow.transform.GetChild(2).GetComponent<Text>().text = "None";
                characterWindow.transform.GetChild(8).GetComponent<Text>().text = "";
                characterWindow.transform.GetChild(9).GetComponent<Text>().text = "";
                characterWindow.transform.GetChild(10).GetComponent<Text>().text = "";
                characterWindow.transform.GetChild(12).GetComponent<Text>().text = "Void";
                characterWindow.transform.GetChild(13).GetComponent<Text>().text = "Void";
                break;
        }
        SetSynagySkill(window1CharacterNum, window2CharacterNum);
    }

    private void SetSynagySkill(int window1Num,int window2Num)
    {
        if (window1Num == 0 && window2Num == 1 || window1Num == 1 && window2Num == 0)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and2;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and2;
        } 
        else if (window1Num == 0 && window2Num == 2 || window1Num == 2 && window2Num == 0)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and3;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and3;
        } 
        else if (window1Num == 0 && window2Num == 3 || window1Num == 3 && window2Num == 0)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and4;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and4;
        }
        else if (window1Num == 0 && window2Num == 4 || window1Num == 4 && window2Num == 0)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and5;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy1and5;
        }
        else if (window1Num == 1 && window2Num == 2 || window1Num == 2 && window2Num == 1)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy2and3;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy2and3;
        }
        else if (window1Num == 1 && window2Num == 3 || window1Num == 3 && window2Num == 1)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy2and4;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy2and4;
        }
        else if (window1Num == 1 && window2Num == 4 || window1Num == 4 && window2Num == 1)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy2and5;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy2and5;
        }
        else if (window1Num == 2 && window2Num == 3 || window1Num == 3 && window2Num == 2)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy3and4;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy3and4;
        }
        else if (window1Num == 2 && window2Num == 4 || window1Num == 4 && window2Num == 2)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy3and5;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy3and5;
        }
        else if (window1Num == 3 && window2Num == 4 || window1Num == 4 && window2Num == 3)
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy4and5;
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = Hy_Test_Data.synagy4and5;
        }
        else
        {
            characterWindow1.transform.GetChild(15).GetComponent<Text>().text = "Void";
            characterWindow2.transform.GetChild(15).GetComponent<Text>().text = "Void";
        }
    }
}
