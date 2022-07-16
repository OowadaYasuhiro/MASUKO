using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Formation
{
    public class FormationCharacterWindow : MonoBehaviour
    {
        [SerializeField]
        private GameObject charaWindowLeft;
        [SerializeField]
        private GameObject charaWindowRight;
        [SerializeField]
        private Sprite[] charaImages;
        [SerializeField]
        private Sprite[] crownImages;
        [SerializeField]
        private Sprite[] bangleImages;
        [SerializeField]
        private Sprite[] ringImages;

        private Charactor leftCharacter;
        private Charactor rightCharacter;

        private int bonusLeftATK = 0;
        private int bonusRightATK = 0;
        private int bonusLeftDEF = 0;
        private int bonusRightDEF = 0;

        private void Start()
        {
            if (Master.formationdeta.selectcharactor1 != null)
            {
                this.leftCharacter = (Charactor)Master.formationdeta.selectcharactor1;

            }
            if (Master.formationdeta.selectcharactor2 != null)
            {
                this.rightCharacter = (Charactor)Master.formationdeta.selectcharactor2;
            }

            AddArifactsStatus();
            DrawLeftWindow();
            DrawRightWindow();
            DrawSynagy();
            DrawCrownImage(Master.formationdeta.charactor1Artifacts[0], charaWindowLeft.transform.GetChild(14));
            DrawCrownImage(Master.formationdeta.charactor2Artifacts[0], charaWindowRight.transform.GetChild(14));
            DrawBangleImage(Master.formationdeta.charactor1Artifacts[1], charaWindowLeft.transform.GetChild(15));
            DrawBangleImage(Master.formationdeta.charactor2Artifacts[1], charaWindowRight.transform.GetChild(15));
            DrawRingImage(Master.formationdeta.charactor1Artifacts[2], charaWindowLeft.transform.GetChild(16));
            DrawRingImage(Master.formationdeta.charactor2Artifacts[2], charaWindowRight.transform.GetChild(16));
        }

        private void DrawLeftWindow()
        {
            if (Master.formationdeta.selectcharactor1 == null)
            {
                return;
            }

            Text level = charaWindowLeft.transform.GetChild(4).GetComponent<Text>();
            Text name = charaWindowLeft.transform.GetChild(6).GetComponent<Text>();
            Text hp = charaWindowLeft.transform.GetChild(8).GetComponent<Text>();
            Text atk = charaWindowLeft.transform.GetChild(9).GetComponent<Text>();
            Text def = charaWindowLeft.transform.GetChild(10).GetComponent<Text>();
            Text skillname = charaWindowLeft.transform.GetChild(11).GetComponent<Text>();
            Text skilleffect = charaWindowLeft.transform.GetChild(12).GetComponent<Text>();

            level.text = leftCharacter.level.ToString();
            name.text = leftCharacter.name;
            hp.text = leftCharacter.hp.ToString();
            atk.text = (leftCharacter.atk + bonusLeftATK).ToString();
            def.text = (leftCharacter.def + bonusLeftDEF).ToString();
            skillname.text = leftCharacter.passiveSkillName;
            skilleffect.text = leftCharacter.passiveSkillEffect;

            DrawCharacter(leftCharacter, /*isLeft=*/ true);
        }
        private void DrawRightWindow()
        {
            if (Master.formationdeta.selectcharactor2 == null)
            {
                return;
            }

            Text level = charaWindowRight.transform.GetChild(4).GetComponent<Text>();
            Text name = charaWindowRight.transform.GetChild(6).GetComponent<Text>();
            Text hp = charaWindowRight.transform.GetChild(8).GetComponent<Text>();
            Text atk = charaWindowRight.transform.GetChild(9).GetComponent<Text>();
            Text def = charaWindowRight.transform.GetChild(10).GetComponent<Text>();
            Text skillname = charaWindowRight.transform.GetChild(11).GetComponent<Text>();
            Text skilleffect = charaWindowRight.transform.GetChild(12).GetComponent<Text>();

            level.text = rightCharacter.level.ToString();
            name.text = rightCharacter.name;
            hp.text = rightCharacter.hp.ToString();
            atk.text = (rightCharacter.atk + bonusRightATK).ToString();
            def.text = (rightCharacter.def + bonusRightDEF).ToString();
            skillname.text = rightCharacter.passiveSkillName;
            skilleffect.text = rightCharacter.passiveSkillEffect;

            DrawCharacter(rightCharacter, /*isLeft=*/ false);
        }
        private void DrawCharacter(Charactor chara, bool isLeft)
        {
            Image charaImage = isLeft ? charaWindowLeft.transform.GetChild(7).GetComponent<Image>() : charaWindowRight.transform.GetChild(7).GetComponent<Image>();

            if (chara.name == "幽霊")
            {
                charaImage.sprite = charaImages[0];
                return;
            }

            if (chara.name == "座敷童")
            {
                charaImage.sprite = charaImages[1];
                return;
            }

            if (chara.name == "鬼")
            {
                charaImage.sprite = charaImages[2];
                return;
            }

            if (chara.name == "ポルターガイスト")
            {
                charaImage.sprite = charaImages[3];
                return;
            }

            if (chara.name == "悪魔")
            {
                charaImage.sprite = charaImages[4];
                return;
            }
        }
        private void DrawSynagy()
        {
            string skillText = "";
            Text leftSynagy = charaWindowLeft.transform.GetChild(13).GetComponent<Text>();
            Text rightSynagy = charaWindowRight.transform.GetChild(13).GetComponent<Text>();

            if (Master.formationdeta.selectcharactor1 == null || Master.formationdeta.selectcharactor2 == null)
            {
                return;
            }

            if ((leftCharacter.name == "幽霊" && rightCharacter.name == "座敷童") || (leftCharacter.name == "座敷童" && rightCharacter.name == "幽霊"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[0];
            } 
            else if ((leftCharacter.name == "幽霊" && rightCharacter.name == "鬼") || (leftCharacter.name == "鬼" && rightCharacter.name == "幽霊"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[1];
            }
            else if ((leftCharacter.name == "幽霊" && rightCharacter.name == "ポルターガイスト") || (leftCharacter.name == "ポルターガイスト" && rightCharacter.name == "幽霊"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[2];
            }
            else if ((leftCharacter.name == "幽霊" && rightCharacter.name == "悪魔") || (leftCharacter.name == "悪魔" && rightCharacter.name == "幽霊"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[3];
            }
            else if ((leftCharacter.name == "座敷童" && rightCharacter.name == "鬼") || (leftCharacter.name == "鬼" && rightCharacter.name == "座敷童"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[4];
            }
            else if ((leftCharacter.name == "座敷童" && rightCharacter.name == "ポルターガイスト") || (leftCharacter.name == "ポルターガイスト" && rightCharacter.name == "座敷童"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[5];
            }
            else if ((leftCharacter.name == "座敷童" && rightCharacter.name == "悪魔") || (leftCharacter.name == "悪魔" && rightCharacter.name == "座敷童"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[6];
            }
            else if ((leftCharacter.name == "鬼" && rightCharacter.name == "ポルターガイスト") || (leftCharacter.name == "ポルターガイスト" && rightCharacter.name == "鬼"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[7];
            }
            else if ((leftCharacter.name == "鬼" && rightCharacter.name == "悪魔") || (leftCharacter.name == "悪魔" && rightCharacter.name == "鬼"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[8];
            }
            else if ((leftCharacter.name == "ポルターガイスト" && rightCharacter.name == "悪魔") || (leftCharacter.name == "悪魔" && rightCharacter.name == "ポルターガイスト"))
            {
                skillText = OrganizationScreen_Deta.synagySkills[9];
            }

            leftSynagy.text = skillText;
            rightSynagy.text = skillText;
        }
        private void AddArifactsStatus()
        {
            if (Master.formationdeta.charactor1Artifacts[0].name == "Onnnenの冠" &&
                Master.formationdeta.charactor1Artifacts[1].name == "Onnnenの腕輪" &&
                Master.formationdeta.charactor1Artifacts[2].name == "Onnnenの指輪")
            {
                bonusLeftATK = 5;
            }
            else
            {
                bonusLeftATK = 0;
            }

            if (Master.formationdeta.charactor2Artifacts[0].name == "Onnnenの冠" &&
                Master.formationdeta.charactor2Artifacts[1].name == "Onnnenの腕輪" &&
                Master.formationdeta.charactor2Artifacts[2].name == "Onnnenの指輪")
            {
                bonusRightATK = 5;
            }
            else
            {
                bonusRightATK = 0;
            }

            if (Master.formationdeta.charactor1Artifacts[0].name == "Yujyouの冠" &&
                Master.formationdeta.charactor1Artifacts[1].name == "Yujyouの腕輪" &&
                Master.formationdeta.charactor1Artifacts[2].name == "Yujyouの指輪")
            {
                bonusLeftDEF = 13;
            }
            else
            {
                bonusLeftDEF = 0;
            }

            if (Master.formationdeta.charactor2Artifacts[0].name == "Yujyouの冠" &&
                Master.formationdeta.charactor2Artifacts[1].name == "Yujyouの腕輪" &&
                Master.formationdeta.charactor2Artifacts[2].name == "Yujyouの指輪")
            {
                bonusRightDEF = 13;
            }
            else
            {
                bonusRightDEF = 0;
            }

            if (Master.formationdeta.charactor1Artifacts[0].name != "noname")
            {
                bonusLeftATK += Master.formationdeta.charactor1Artifacts[0].addValue;
            }
            if (Master.formationdeta.charactor1Artifacts[1].name != "noname")
            {
                bonusLeftATK += Master.formationdeta.charactor1Artifacts[1].addValue;
            }
            if (Master.formationdeta.charactor1Artifacts[2].name != "noname")
            {
                bonusLeftATK += Master.formationdeta.charactor1Artifacts[2].addValue;
            }

            if (Master.formationdeta.charactor2Artifacts[0].name != "noname")
            {
                bonusRightATK += Master.formationdeta.charactor2Artifacts[0].addValue;
            }
            if (Master.formationdeta.charactor2Artifacts[1].name != "noname")
            {
                bonusRightATK += Master.formationdeta.charactor2Artifacts[1].addValue;
            }
            if (Master.formationdeta.charactor2Artifacts[2].name != "noname")
            {
                bonusRightATK += Master.formationdeta.charactor2Artifacts[2].addValue;
            }
        }

        private void DrawCrownImage(Artifact artifact,Transform buttonPos)
        {
            switch (artifact.name)
            {
                case "Huaの冠":
                    buttonPos.GetComponent<Image>().sprite = crownImages[0];
                    break;
                case "Onnnenの冠":
                    buttonPos.GetComponent<Image>().sprite = crownImages[1];
                    break;
                case "Rekisenの冠":
                    buttonPos.GetComponent<Image>().sprite = crownImages[2];
                    break;
                case "Yujyouの冠":
                    buttonPos.GetComponent<Image>().sprite = crownImages[3];
                    break;
                case "Akatukiの冠":
                    buttonPos.GetComponent<Image>().sprite = crownImages[4];
                    break;
                default:
                    Debug.Log("?");
                    break;
            }

            if(artifact.name != "noname")
            {
                buttonPos.GetComponentInChildren<Text>().text = "Lv" + artifact.level;
            }
            else
            {
                buttonPos.GetComponentInChildren<Text>().text = "";
            }
        }
        private void DrawBangleImage(Artifact artifact, Transform buttonPos)
        {
            switch (artifact.name)
            {
                case "Huaの腕輪":
                    buttonPos.GetComponent<Image>().sprite = bangleImages[0];
                    break;
                case "Onnnenの腕輪":
                    buttonPos.GetComponent<Image>().sprite = bangleImages[1];
                    break;
                case "Rekisenの腕輪":
                    buttonPos.GetComponent<Image>().sprite = bangleImages[2];
                    break;
                case "Yujyouの腕輪":
                    buttonPos.GetComponent<Image>().sprite = bangleImages[3];
                    break;
                case "Akatukiの腕輪":
                    buttonPos.GetComponent<Image>().sprite = bangleImages[4];
                    break;
                default:
                    Debug.Log("?");
                    break;
            }

            if (artifact.name != "noname")
            {
                buttonPos.GetComponentInChildren<Text>().text = "Lv" + artifact.level;
            }
            else
            {
                buttonPos.GetComponentInChildren<Text>().text = "";
            }
        }
        private void DrawRingImage(Artifact artifact, Transform buttonPos)
        {
            switch (artifact.name)
            {
                case "Huaの指輪":
                    buttonPos.GetComponent<Image>().sprite = ringImages[0];
                    break;
                case "Onnnenの指輪":
                    buttonPos.GetComponent<Image>().sprite = ringImages[1];
                    break;
                case "Rekisenの指輪":
                    buttonPos.GetComponent<Image>().sprite = ringImages[2];
                    break;
                case "Yujyouの指輪":
                    buttonPos.GetComponent<Image>().sprite = ringImages[3];
                    break;
                case "Akatukiの指輪":
                    buttonPos.GetComponent<Image>().sprite = ringImages[4];
                    break;
                default:
                    Debug.Log("?");
                    break;
            }

            if (artifact.name != "noname")
            {
                buttonPos.GetComponentInChildren<Text>().text = "Lv" + artifact.level;
            }
            else
            {
                buttonPos.GetComponentInChildren<Text>().text = "";
            }
        }
    }
}