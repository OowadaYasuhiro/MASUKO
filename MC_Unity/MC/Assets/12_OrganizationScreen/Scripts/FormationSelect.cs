using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Formation
{
    public class FormationSelect : MonoBehaviour
    {
        public void OnClickCharacter(int characterNum)
        {
            Charactor chara = new Charactor();

            switch (characterNum)
            {
                case 0:
                    chara = new Charactor("幽霊");
                    break;
                case 1:
                    chara = new Charactor("座敷童");
                    break;
                case 2:
                    chara = new Charactor("鬼");
                    break;
                case 3:
                    chara = new Charactor("ポルターガイスト");
                    break;
                case 4:
                    chara = new Charactor("悪魔");
                    break;
                default:
                    Debug.LogError("");
                    break;
            }

            if (OrganizationScreen_Deta.isLeftCharacter)
            {
                Master.formationdeta.selectcharactor1 = chara;
            }
            else
            {
                Master.formationdeta.selectcharactor2 = chara;
            }

            SceneManager.LoadScene("OrganizationScreenScene");
        }
    }
}