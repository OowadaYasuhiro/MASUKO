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
    [SerializeField]
    public Text[] textLQN;
    [SerializeField]
    public Text[] textQN;
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
    private string textSname;
    private string SelectStagestageB;
    private string Difdifficulty;
    private string SelectOn;
    private string QuestOn;
    private int sNumber;
    private int lsNumber;
    private int stageB_num;
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
        Selectstage(0);
        //PlayerPrefs.GetInt("SCORE", 0);
        difficulty_num = 1;
        stageB_num = 1;
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

        Debug.Log(Difdifficulty);

        Debug.Log(SelectOn);

        Debug.Log(QuestOn);
    }

    //クエストの処理
    public void Selectstage(int sNumber)
    {
        switch (sNumber)
        {
            case 0:
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
                Difdifficulty_num(1);
                break;
            case 1:
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
                Difdifficulty_num(1);
                break;
            case 2:
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
                Difdifficulty_num(1);
                break;
        }
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
        //SelectOnClick(1);
    }
    
    public void Selecttext2()
    {
        Selecttext(2);
        //SelectOnClick(2);
    }

    public void Selecttext3()
    {
        Selecttext(3);
        //SelectOnClick(3);
    }

    public void Selecttext4()
    {
        Selecttext(4);
        //SelectOnClick(4);
    }

    public void Selecttext5()
    {
        Selecttext(5);
        //SelectOnClick(5);
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
        switch (st)
        {
            case 1:
                textSname = "破滅の始まり";
                break;
            case 2:
                textSname = "破滅の始まり２";
                break;
            case 3:
                textSname = "破滅の始まり３";
                break;
            case 4:
                textSname = "破滅の始まり４";
                break;
            case 5:
                textSname = "破滅の始まり５";
                break;
        }
        textLQN[0].text = textTname;
        textQN[0].text = textAbbreviation + "." + st + " " + textSname;
    }

    /*public void SelectOnClick()
    {
        switch (textTname)
        {
            case "メインクエスト":
            case "デイリークエスト":
            case "イベントクエスト":
                SelectStage1(1);
                SelectStage1(2);
                SelectStage1(3);
                SelectStage1(4);
                SelectStage1(5);
                break;
        }
    }

    public void SelectStage1(int st)
    {
        switch (st)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                break;
        }
    }*/

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

    public void Difdifficulty_num(int difficulty_num)
    {
        switch (difficulty_num)
        {
            case 1:
                Difdifficulty = "イージー";
                Debug.Log(Difdifficulty);
                break;
            case　2:
                Difdifficulty = "ノーマル";
                Debug.Log(Difdifficulty);
                break;
            case 3:
                Difdifficulty = "ハード";
                Debug.Log(Difdifficulty);
                break;
        }
    }

    public void SelectStagestageB_num(int stageB_num)
    {
        switch (stageB_num)
        {
            case 1:
                SelectStagestageB = "ステージ1";
                Debug.Log(SelectStagestageB);
                break;
            case 2:
                SelectStagestageB = "ステージ２";
                Debug.Log(SelectStagestageB);
                break;
            case 3:
                SelectStagestageB = "ステージ３";
                Debug.Log(SelectStagestageB);
                break;
            case 4:
                SelectStagestageB = "ステージ４";
                Debug.Log(SelectStagestageB);
                break;
        }
    }
    public void SelectOnClick(int st)
    {
        switch (st)
        {
            case 1:
                SelectOn = "EP.1";
                break;
            case 2:
                SelectOn = "EP.2";
                break;
            case 3:
                SelectOn = "EP.3";
                break;
            case 4:
                SelectOn = "EP.4";
                break;
            case 5:
                SelectOn = "EP.5";
                break;
        }
    }
    public void QuestOnClick(int quest)
    {
        switch (quest)
        {
            case 1:
                QuestOn = "メインクエスト";
                break;
            case 2:
                QuestOn ="デイリークエスト";
                break;
            case 3:
                QuestOn ="イベントクエスト";
                break;
        }
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
}

 switch (difficulty_num)
                        {
                            case 1:
                            case 2:
                            case 3:
                                break;
                        }
                        break;*/
/*[SerializeField]
public Text[] textDifficulty;*/


