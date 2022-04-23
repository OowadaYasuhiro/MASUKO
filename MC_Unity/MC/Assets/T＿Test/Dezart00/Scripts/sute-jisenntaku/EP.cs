using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EP : MonoBehaviour
{
    // スコア変数
    /*public static*/
    [SerializeField]
    public int[] stage_num; 
    // スコア変数
    /*public static*/
    [SerializeField]
    public int[] lstage_num; 
    //テキスト
    [SerializeField]
    public Text[] textStage;
    [SerializeField]
    public Text[] textQ;
    //ボタンオブジェクト
    [SerializeField]
    private GameObject[] stageDay;
    [SerializeField]
    private GameObject[] stageEX;
    [SerializeField]
    private GameObject[] stageEP;
    [SerializeField]
    private GameObject[] objGetStage;
    [SerializeField]
    private GameObject[] objGetQ;
    [SerializeField]
    private GameObject[] Difficulty;

    private string textAbbreviation;
    private string textTname;
    private int sNumber;
    private int lsNumber;
    private int difficulty_num;

    //Dictionary<string, int> stagetest = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        //現在のstage_numを呼び出す
        for (int i = 0; i < stage_num.Length; i++)
        {
            stage_num[i] = 1;
        }

        for(int i = 0; i < lstage_num.Length; i++)
        {
            lstage_num[i] = 1;
        }
        SelectstageEP();
        //PlayerPrefs.GetInt("SCORE", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Selectstage_num();
        Selectlstage_num();
    }

    //ステージクリアの合計を計測
    public void OnClick()
    {
        stage_num[sNumber]++;
        Debug.Log(stage_num[sNumber] + "成功！！");
        if (stage_num[sNumber] % 5 == 0)
        {
            lstage_num[lsNumber]++;
            stage_num[sNumber] = 1;
        }
        Debug.Log(lstage_num[lsNumber]);

        Debug.Log(difficulty_num);
    }

    //メインクエストの処理
    public void SelectstageEP()
    {
        textTname = "メインクエスト";
        textAbbreviation = "EP";
        sNumber = 0;
        lsNumber = 0;
        Selectsateg();
        Selecttext2();
        Selecttext3();
        Selecttext4();
        Selecttext5();
        Selecttext1();
        Selectstage_num();
        Selectlstage_num();
    }

    //デイリークエストの処理
    public void SelectstageDay()
    {
        textTname = "デイリークエスト";
        textAbbreviation = "Day";
        sNumber = 1;
        lsNumber = 1;
        Selectsateg();
        Selecttext2();
        Selecttext3();
        Selecttext4();
        Selecttext5();
        Selecttext1();
        Selectstage_num();
        Selectlstage_num();
    }

    //イベントクエストの処理
    public void SelectstageEX()
    {
        textTname = "イベントクエスト";
        textAbbreviation = "EX";
        sNumber = 2;
        lsNumber = 2;
        Selectsateg();
        Selecttext2();
        Selecttext3();
        Selecttext4();
        Selecttext5();
        Selecttext1();
        Selectstage_num();
        Selectlstage_num();
    }

    //章選択のテキスト変更処理
    public void Selectsateg()
    {
        if (lstage_num[lsNumber] <= 1)
        {
            SelectLstage_numtrue();
        }
        else if (lstage_num[lsNumber] <=2)
        {
            objGetQ[0].SetActive(false);
            objGetQ[1].SetActive(true);
            objGetQ[2].SetActive(true);
            objGetQ[3].SetActive(true);
        }
        else if (lstage_num[lsNumber] <= 3)
        {
            objGetQ[0].SetActive(false);
            objGetQ[1].SetActive(false);
            objGetQ[2].SetActive(true);
            objGetQ[3].SetActive(true);
        }
        else if (lstage_num[lsNumber] <= 4)
        {
            objGetQ[0].SetActive(false);
            objGetQ[1].SetActive(false);
            objGetQ[2].SetActive(false);
            objGetQ[3].SetActive(true);
        }
        else
        {
            SelectLstage_numfalse();
        }

        int j = 1;
        for (int i = 0; i <= 8; i++)
        {
            textQ[i].text = textTname;
        }
        for (int i = 9; i <= textQ.Length; i++)
        {
            if (i <= 13)
            {
                textQ[i].text = textAbbreviation + "." + j;
                j++;
            }
            else if (i >= 14 && i <= 17)
            {
                textQ[i].text = textAbbreviation + "." + (j - 4);
                j++;
            }
        }
    }

    /*public void Select()
    {
        switch ()
        {
            case:
                break;
        }
    }*/

    //章セレクトボタンテキスト
    public void Selecttext1()
    {
        Selecttext(1);
    }
    
    public void Selecttext2()
    {
        Selecttext(2);
    }

    public void Selecttext3()
    {
        Selecttext(3);
    }

    public void Selecttext4()
    {
        Selecttext(4);
    }

    public void Selecttext5()
    {
        Selecttext(5);
    }

    //ステージ選択のテキスト変更処理
    public void Selecttext(int st)
    {
        if (lstage_num[lsNumber] <= st)
        {
            SelectStage_numtrue();
        }
        else
        {
            SelectStage_numfalse();
        }

        int j = 1;
        for (int i = 0; i <= textStage.Length; i++)
        {
            if (i <= 3)
            {
                textStage[i].text = textAbbreviation + "." + st + "-" + j;
                j++;
            }
            else if (i >= 4 && i <= 6)
            {
                textStage[i].text = textAbbreviation + "." + st + "-" + (j - 3);
                j++;
            }
        }
    }

    public void SelectStage_numfalse()
    {
        objGetStage[0].SetActive(false);
        objGetStage[1].SetActive(false);
        objGetStage[2].SetActive(false);
    }

    public void SelectStage_numtrue()
    {
        objGetStage[0].SetActive(true);
        objGetStage[1].SetActive(true);
        objGetStage[2].SetActive(true);
    }

    public void SelectLstage_numfalse()
    {
        objGetQ[0].SetActive(false);
        objGetQ[1].SetActive(false);
        objGetQ[2].SetActive(false);
        objGetQ[3].SetActive(false);
    }

    public void SelectLstage_numtrue()
    {
        objGetQ[0].SetActive(true);
        objGetQ[1].SetActive(true);
        objGetQ[2].SetActive(true);
        objGetQ[3].SetActive(true);
    }

    //ステージ解放処理
    public void Selectstage_num()
    {
        if (stage_num[sNumber] >= 2)
        {
            objGetStage[0].SetActive(false);
        }

        if (stage_num[sNumber] >= 3)
        {
            objGetStage[1].SetActive(false);
        }

        if (stage_num[sNumber] >= 4)
        {
            objGetStage[2].SetActive(false);
        }
    }

    //章解放処理
    public void Selectlstage_num()
    {
        if (lstage_num[lsNumber] >= 2)
        {
            objGetQ[0].SetActive(false);
        }

        if (lstage_num[lsNumber] >= 3)
        {
            objGetQ[1].SetActive(false);
        }

        if (lstage_num[lsNumber] >= 4)
        {
            objGetQ[2].SetActive(false);
        }

        if (lstage_num[lsNumber] >= 5)
        {
            objGetQ[3].SetActive(false);
        }
    }

    public void DifEasy()
    {
        difficulty_num = 0;
    }

    public void DifNormal()
    {
        difficulty_num = 1;
    }

    public void Difhard()
    {
        difficulty_num = 2;
    }

}

//public GameObject data;
/*GameObject EP1 = GameObject.Find("GameObjectEP");
        Debug.Log("target1 = " + EP1);*/
/*public void OnClickEP1Button()
    {
        for (var i = 0; i < buttons.Length; i++)
        {
            if (i == 0)
            {
                buttons[0].GetComponent<Image>().color = Color.white;
                continue;
            }
            buttons[i].GetComponent<Image>().color = Color.gray;
        }
    }

    public void OnClick()
    {
        Debug.Log("EP1");
    }*/

/*public void Stage()
    {
        //stage_numが２以上のとき、ステージ２を解放する。以下同様
        for (int i = 0; i <= objGetQ_.Length; i++)
        {
            for (int j = 2; j <= stage_num; j++)
            {
                Debug.Log(j);
                if (stage_num >= 2)
                {
                    gameObject.AddComponent(objGetQ_[i].SetActive(false));
                }
                if (stage_num >= j)
                {
                    objGetQ_[i].SetActive(false);
                }
            }
        }
    }*/

/*public void stageSelect()
{
    switch (lstage_num)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            break;
    }
}*/
/*[SerializeField]
public Text[] textDifficulty;*/


