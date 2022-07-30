using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Formation
{
    public class FormationSelect : MonoBehaviour
    {
        [SerializeField]
        private int characterNumber;


        private void FixedUpdate()
        {
            if (OrganizationScreen_Deta.isLeftCharacter)
            {
                if (this.characterNumber == OrganizationScreen_Deta.leftCharacterNum)
                {
                    this.gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.gray;
                    this.gameObject.GetComponent<Button>().enabled = false;
                }
                else if (this.characterNumber == OrganizationScreen_Deta.rightCharacterNum)
                {
                    this.gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.gray;
                    this.gameObject.GetComponent<Button>().enabled = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().enabled = true;
                }
            }
            else
            {
                if (this.characterNumber == OrganizationScreen_Deta.rightCharacterNum)
                {
                    this.gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.gray;
                    this.gameObject.GetComponent<Button>().enabled = false;
                }
                else if (this.characterNumber == OrganizationScreen_Deta.leftCharacterNum)
                {
                    this.gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.gray;
                    this.gameObject.GetComponent<Button>().enabled = false;
                }
                else
                {
                    this.gameObject.GetComponent<Button>().enabled = true;
                }
            }
        }

        public void OnClickCharacter()
        {
            Charactor chara = new Charactor();
            int charaNum = -1;

            switch (characterNumber)
            {
                case 0:
                    chara = OrganizationScreen_Deta.ghost;
                    charaNum = 0;
                    OrganizationScreen_Deta.playVoiceNum = 0;
                    break;
                case 1:
                    chara = OrganizationScreen_Deta.zasikiwarasi;
                    OrganizationScreen_Deta.playVoiceNum = 1;
                    charaNum = 1;
                    break;
                case 2:
                    chara = OrganizationScreen_Deta.ogre;
                    OrganizationScreen_Deta.playVoiceNum = 2;
                    charaNum = 2;
                    break;
                case 3:
                    chara = OrganizationScreen_Deta.poltergeist;
                    OrganizationScreen_Deta.playVoiceNum = 3;
                    charaNum = 3;
                    break;
                case 4:
                    chara = OrganizationScreen_Deta.demon;
                    OrganizationScreen_Deta.playVoiceNum = 4;
                    charaNum = 4;
                    break;
                default:
                    Debug.LogError("");
                    break;
            }

            if (OrganizationScreen_Deta.isLeftCharacter)
            {
                Master.formationdeta.selectcharactor1 = chara;
                OrganizationScreen_Deta.leftCharacterNum = charaNum;
            }
            else
            {
                Master.formationdeta.selectcharactor2 = chara;
                OrganizationScreen_Deta.rightCharacterNum = charaNum;
            }

            OrganizationScreen_Deta.isCharaSelect = false;
            SceneManager.LoadScene("OrganizationScreenScene");
        }
    }
}