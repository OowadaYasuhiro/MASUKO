using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mission
{
    public class MissionDaily : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] buttonImages;
        [SerializeField]
        private GameObject missonDetail;

        private void Start()
        {
            ButtonColorDarken();
        }
        private void Update()
        {
            if (MissionScreen_Deta.kinds != MissionKind.DAILY)
            {
                ButtonColorDarken();
            }
        }

        public void OnClickDaily()
        {
            ButtonColorBrightly();
            MissionScreen_Deta.kinds = MissionKind.DAILY;
        }

        private void DrawMissionDetailText()
        {

        }

        private void ButtonColorBrightly()
        {
            this.gameObject.GetComponent<Image>().sprite = buttonImages[0];
        }
        private void ButtonColorDarken()
        {
            this.gameObject.GetComponent<Image>().sprite = buttonImages[1];
        }
    }
}
