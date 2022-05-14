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
    private GameObject[] stageC;
    [SerializeField]
    private GameObject[] stageSQ;
    [SerializeField]
    private GameObject[] stage;
    [SerializeField]
    private GameObject[] objGetStage;
    [SerializeField]
    private GameObject[] objGetQ;
    [SerializeField]
    private GameObject[] Difficulty;
    [SerializeField]
    public GameObject fcs;

    private string textAbbreviation;
    private string textTname;
    private string textSname;
    private string SelectStagestageB;
    public string Difdifficulty;
    public string SelectOn;
    public string QuestOn;
    public int sNumber;
    public int lsNumber;
    public int stageB_num;
    public int difficulty_num;
    public int SelectStagestageB_num_num;
    public int SelectOn_num;

    FinalConfirmationScreen FCS;

    bool isCalledOnce = false;
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
        SelectOnClick(1);
        QuestOnClick(1);
        Difdifficulty_num(1);
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
    public void Selectstage(int number)
    {
        switch (number)
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
                SelectStagestageB_num(1);
                CColor();
                DifColor();
                //this.FCS.EP();
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
                SelectStagestageB_num(1);
                CColor();
                DifColor();
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
                SelectStagestageB_num(1);
                CColor();
                DifColor();
                break;
        }
    }

    //章選択のテキスト変更処理
    public void Selectsateg()
    {
        //章選択の有無
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
        SelectOnClick(1);
    }
    
    public void Selecttext2()
    {
        Selecttext(2);
        SelectOnClick(2);
    }

    public void Selecttext3()
    {
        Selecttext(3);
        SelectOnClick(3);
    }

    public void Selecttext4()
    {
        Selecttext(4);
        SelectOnClick(4);
    }

    public void Selecttext5()
    {
        Selecttext(5);
        SelectOnClick(5);
    }

    //ステージ選択のテキスト変更処理
    public void Selecttext(int st)
    {
        //ステージ選択の有無
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
        SQuestOnClick(st);
        textLQN[0].text = textTname;
        textQN[0].text = textAbbreviation + "." + st + " " + textSname;
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

    public void Difdifficulty_num(int dif)
    {
        switch (dif)
        {
            case 1:
                Difdifficulty = "イージー";
                Debug.Log(Difdifficulty);
                difficulty_num = 1;
                DifColor();
                break;
            case　2:
                Difdifficulty = "ノーマル";
                Debug.Log(Difdifficulty);
                difficulty_num = 2;
                DifColor();
                break;
            case 3:
                Difdifficulty = "ハード";
                Debug.Log(Difdifficulty);
                difficulty_num = 3;
                DifColor();
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
                SelectStagestageB_num_num = 1;
                sColor();
                break;
            case 2:
                SelectStagestageB = "ステージ２";
                Debug.Log(SelectStagestageB);
                SelectStagestageB_num_num = 2;
                sColor();
                break;
            case 3:
                SelectStagestageB = "ステージ３";
                Debug.Log(SelectStagestageB);
                SelectStagestageB_num_num = 3;
                sColor();
                break;
            case 4:
                SelectStagestageB = "ステージ４";
                Debug.Log(SelectStagestageB);
                SelectStagestageB_num_num = 4;
                sColor();
                break;
        }
    }
    public void SelectOnClick(int st)
    {
        switch (st)
        {
            case 1:
                SelectOn = "EP.1";
                SelectOn_num = 1;
                SelectStagestageB_num(1);
                CQColor();
                break;
            case 2:
                SelectOn = "EP.2";
                SelectOn_num = 2;
                SelectStagestageB_num(1);
                CQColor();
                break;
            case 3:
                SelectOn = "EP.3";
                SelectOn_num = 3;
                SelectStagestageB_num(1);
                CQColor();
                break;
            case 4:
                SelectOn = "EP.4";
                SelectOn_num = 4;
                SelectStagestageB_num(1);
                CQColor();
                break;
            case 5:
                SelectOn = "EP.5";
                SelectOn_num = 5;
                SelectStagestageB_num(1);
                CQColor();
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
    public void SQuestOnClick(int st)
    {
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
    }
    //選択時のカラー変更
    public void CColor()
    {
        switch (lsNumber)
        {
            case 0:
                stageC[0].GetComponent<Image>().color = Color.red;
                stageC[1].GetComponent<Image>().color = Color.white;
                stageC[2].GetComponent<Image>().color = Color.white;
                break;
            case 1:
                stageC[1].GetComponent<Image>().color = Color.green;
                stageC[0].GetComponent<Image>().color = Color.white;
                stageC[2].GetComponent<Image>().color = Color.white;
                break;
            case 2:
                stageC[2].GetComponent<Image>().color = Color.blue;
                stageC[0].GetComponent<Image>().color = Color.white;
                stageC[1].GetComponent<Image>().color = Color.white;
                break;
        }
    }
    public void CQColor()
    {
        if(lsNumber == 0)
        {
            switch (SelectOn)
            {
                case "EP.1":
                    stageSQ[0].GetComponent<Image>().color = Color.red;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.2":
                    stageSQ[1].GetComponent<Image>().color = Color.red;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.3":
                    stageSQ[2].GetComponent<Image>().color = Color.red;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.4":
                    stageSQ[3].GetComponent<Image>().color = Color.red;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.5":
                    stageSQ[4].GetComponent<Image>().color = Color.red;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
        else if(lsNumber == 1)
        {
            switch (SelectOn)
            {
                case "EP.1":
                    stageSQ[0].GetComponent<Image>().color = Color.green;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.2":
                    stageSQ[1].GetComponent<Image>().color = Color.green;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.3":
                    stageSQ[2].GetComponent<Image>().color = Color.green;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.4":
                    stageSQ[3].GetComponent<Image>().color = Color.green;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.5":
                    stageSQ[4].GetComponent<Image>().color = Color.green;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
        else if(lsNumber == 2)
        {
            switch (SelectOn)
            {
                case "EP.1":
                    stageSQ[0].GetComponent<Image>().color = Color.blue;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.2":
                    stageSQ[1].GetComponent<Image>().color = Color.blue;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.3":
                    stageSQ[2].GetComponent<Image>().color = Color.blue;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.4":
                    stageSQ[3].GetComponent<Image>().color = Color.blue;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[4].GetComponent<Image>().color = Color.white;
                    break;
                case "EP.5":
                    stageSQ[4].GetComponent<Image>().color = Color.blue;
                    stageSQ[0].GetComponent<Image>().color = Color.white;
                    stageSQ[1].GetComponent<Image>().color = Color.white;
                    stageSQ[2].GetComponent<Image>().color = Color.white;
                    stageSQ[3].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
    }
    public void sColor()
    {
        if(lsNumber == 0)
        {
            switch (SelectStagestageB)
            {
                case "ステージ1":
                    stage[0].GetComponent<Image>().color = Color.red;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ２":
                    stage[1].GetComponent<Image>().color = Color.red;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ３":
                    stage[2].GetComponent<Image>().color = Color.red;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ４":
                    stage[3].GetComponent<Image>().color = Color.red;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
        else if(lsNumber == 1)
        {
            switch (SelectStagestageB)
            {
                case "ステージ1":
                    stage[0].GetComponent<Image>().color = Color.green;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ２":
                    stage[1].GetComponent<Image>().color = Color.green;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ３":
                    stage[2].GetComponent<Image>().color = Color.green;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ４":
                    stage[3].GetComponent<Image>().color = Color.green;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
        else if(lsNumber == 2) 
        { 
            switch (SelectStagestageB)
            {
                case "ステージ1":
                    stage[0].GetComponent<Image>().color = Color.blue;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ２":
                    stage[1].GetComponent<Image>().color = Color.blue;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ３":
                    stage[2].GetComponent<Image>().color = Color.blue;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[3].GetComponent<Image>().color = Color.white;
                    break;
                case "ステージ４":
                    stage[3].GetComponent<Image>().color = Color.blue;
                    stage[0].GetComponent<Image>().color = Color.white;
                    stage[1].GetComponent<Image>().color = Color.white;
                    stage[2].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
    }
    public void DifColor()
    {
        if(lsNumber == 0)
        {
            switch (Difdifficulty)
            {
                case "イージー":
                    Difficulty[0].GetComponent<Image>().color = Color.red;
                    Difficulty[1].GetComponent<Image>().color = Color.white;
                    Difficulty[2].GetComponent<Image>().color = Color.white;
                    break;
                case "ノーマル":
                    Difficulty[1].GetComponent<Image>().color = Color.red;
                    Difficulty[0].GetComponent<Image>().color = Color.white;
                    Difficulty[2].GetComponent<Image>().color = Color.white;
                    break;
                case "ハード":
                    Difficulty[2].GetComponent<Image>().color = Color.red;
                    Difficulty[0].GetComponent<Image>().color = Color.white;
                    Difficulty[1].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
        else if (lsNumber == 1)
        {
            switch (Difdifficulty)
            {
                case "イージー":
                    Difficulty[0].GetComponent<Image>().color = Color.green;
                    Difficulty[1].GetComponent<Image>().color = Color.white;
                    Difficulty[2].GetComponent<Image>().color = Color.white;
                    break;
                case "ノーマル":
                    Difficulty[1].GetComponent<Image>().color = Color.green;
                    Difficulty[0].GetComponent<Image>().color = Color.white;
                    Difficulty[2].GetComponent<Image>().color = Color.white;
                    break;
                case "ハード":
                    Difficulty[2].GetComponent<Image>().color = Color.green;
                    Difficulty[0].GetComponent<Image>().color = Color.white;
                    Difficulty[1].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
        else if (lsNumber == 2)
        {
            switch (Difdifficulty)
            {
                case "イージー":
                    Difficulty[0].GetComponent<Image>().color = Color.blue;
                    Difficulty[1].GetComponent<Image>().color = Color.white;
                    Difficulty[2].GetComponent<Image>().color = Color.white;
                    break;
                case "ノーマル":
                    Difficulty[1].GetComponent<Image>().color = Color.blue;
                    Difficulty[0].GetComponent<Image>().color = Color.white;
                    Difficulty[2].GetComponent<Image>().color = Color.white;
                    break;
                case "ハード":
                    Difficulty[2].GetComponent<Image>().color = Color.blue;
                    Difficulty[0].GetComponent<Image>().color = Color.white;
                    Difficulty[1].GetComponent<Image>().color = Color.white;
                    break;
            }
        }
    }

}

