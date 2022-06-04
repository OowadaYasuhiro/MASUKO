using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalConfirmationScreen : MonoBehaviour
{
    [SerializeField]
    public GameObject[] source;
    [SerializeField]
    public GameObject[] star;
    [SerializeField]
    public GameObject[] back;
    [SerializeField]
    public Image[] stageimages;
    [SerializeField]
    public Image[] caractorimages;
    [SerializeField]
    public Image[] doropimages;
    [SerializeField]
    public Sprite[] dorpItemUi;
    [SerializeField]
    public Text FCSQtext;
    [SerializeField]
    public Text FCRLtext;
    [SerializeField]
    public Text FCStext;
    [SerializeField]
    public EP epScript;


    // Start is called before the first frame update
    void Start()
    {
        source[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //確認画面表示
    public void FCScreendo()
    {
        source[0].SetActive(true);
    }
    //確認画面非表示
    public void FCScreendc()
    {
        source[0].SetActive(false);
    }


    public void ItemeDorp()
    {
        for (int i = 0;i < doropimages.Length; i++)
        {
            //アイテム画像初期化
            doropimages[i].sprite = null;
            if(i < 3) 
            { 
                doropimages[i].sprite = dorpItemUi[i];
            }
            else if(i >= 3 && i <= 5 && epScript.QuestNumber > 0)
            {
                doropimages[i].sprite = dorpItemUi[i];
            }
        }
    }
}
