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
<<<<<<< HEAD
    public Text[] textQ_;
    [SerializeField]
    public Text[] textQ;
    [SerializeField]
    public Text[] textDifficulty;
    //ボタンオブジェクト
    [SerializeField]
    private GameObject[] stageDay;
    [SerializeField]
    private GameObject[] stageEX;
    [SerializeField]
    private GameObject[] stageEP;
    [SerializeField]
    private GameObject[] objGetQ_;
=======
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
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    [SerializeField]
    private GameObject[] objGetQ;
    [SerializeField]
    private GameObject[] Difficulty;
<<<<<<< HEAD

    private string textAbbreviation;
    private string textTname;
    private int sNumber;
    private int lsNumber;

=======
    [SerializeField]
    public GameObject fcs;
    [SerializeField]
    public GameObject targetObj;
    FinalConfirmationScreen ss;

    public int[] ep;

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
   // var colors;

    bool isCalledOnce = false;
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
        SelectstageEP();
        //PlayerPrefs.GetInt("SCORE", 0);
=======
        Selectstage(0);
        SelectOnClick(1);
        QuestOnClick(1);
        Difdifficulty_num(1);
        //PlayerPrefs.GetInt("SCORE", 0);
        difficulty_num = 1;
        stageB_num = 1;
        ss = GetComponent<FinalConfirmationScreen>();

        for (int i = 0; i < ep.Length; i++)
        {
            ep[i] = 0;
        }
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
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
=======

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
                Selecttext(1);
                SelectOnClick(1);
                Selectstage_num();
                Selectlstage_num();
                SelectStagestageB_num(1);
                CColor();
                DifColor();
                SS();
                break;
            case 1:
                textTname = "デイリークエスト";
                textAbbreviation = "Day";
                sNumber = 1;
                lsNumber = 1;
                Selectsateg();
                Selecttext(1);
                SelectOnClick(1);
                Selectstage_num();
                Selectlstage_num();
                SelectStagestageB_num(1);
                CColor();
                DifColor();
                SS();
                break;
            case 2:
                textTname = "イベントクエスト";
                textAbbreviation = "EX";
                sNumber = 2;
                lsNumber = 2;
                Selectsateg();
                Selecttext(1);
                SelectOnClick(1);
                Selectstage_num();
                Selectlstage_num();
                SelectStagestageB_num(1);
                CColor();
                DifColor();
                SS();
                break;
        }
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }

    //章選択のテキスト変更処理
    public void Selectsateg()
    {
<<<<<<< HEAD
=======
        //章選択の有無
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
=======

>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }

    /*public void Select()
    {
        switch ()
        {
            case:
                break;
        }
    }*/

<<<<<<< HEAD
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
=======
    //ステージ選択のテキスト変更処理
    public void Selecttext(int st)
    {
        //ステージ選択の有無
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        if (lstage_num[lsNumber] <= st)
        {
            SelectStage_numtrue();
        }
        else
        {
            SelectStage_numfalse();
        }

        int j = 1;
<<<<<<< HEAD
        for (int i = 0; i <= textQ_.Length; i++)
        {
            if (i <= 3)
            {
                textQ_[i].text = textAbbreviation + "." + st + "-" + j;
=======
        for (int i = 0; i <= textStage.Length; i++)
        {
            if (i <= 3)
            {
                textStage[i].text = textAbbreviation + "." + st + "-" + j;
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
                j++;
            }
            else if (i >= 4 && i <= 6)
            {
<<<<<<< HEAD
                textQ_[i].text = textAbbreviation + "." + st + "-" + (j - 3);
                j++;
            }
        }
=======
                textStage[i].text = textAbbreviation + "." + st + "-" + (j - 3);
                j++;
            }
        }
        SQuestOnClick(st);
        textLQN[0].text = textTname;
        textQN[0].text = textAbbreviation + "." + st + " " + textSname;
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }

    public void SelectStage_numfalse()
    {
<<<<<<< HEAD
        objGetQ_[0].SetActive(false);
        objGetQ_[1].SetActive(false);
        objGetQ_[2].SetActive(false);
=======
        objGetStage[0].SetActive(false);
        objGetStage[1].SetActive(false);
        objGetStage[2].SetActive(false);
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }

    public void SelectStage_numtrue()
    {
<<<<<<< HEAD
        objGetQ_[0].SetActive(true);
        objGetQ_[1].SetActive(true);
        objGetQ_[2].SetActive(true);
=======
        objGetStage[0].SetActive(true);
        objGetStage[1].SetActive(true);
        objGetStage[2].SetActive(true);
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
            objGetQ_[0].SetActive(false);
=======
            objGetStage[0].SetActive(false);
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        }

        if (stage_num[sNumber] >= 3)
        {
<<<<<<< HEAD
            objGetQ_[1].SetActive(false);
=======
            objGetStage[1].SetActive(false);
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        }

        if (stage_num[sNumber] >= 4)
        {
<<<<<<< HEAD
            objGetQ_[2].SetActive(false);
=======
            objGetStage[2].SetActive(false);
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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

<<<<<<< HEAD

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
=======
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
                SS();
                break;
            case 2:
                SelectStagestageB = "ステージ２";
                Debug.Log(SelectStagestageB);
                SelectStagestageB_num_num = 2;
                sColor();
                SS();
                break;
            case 3:
                SelectStagestageB = "ステージ３";
                Debug.Log(SelectStagestageB);
                SelectStagestageB_num_num = 3;
                sColor();
                SS();
                break;
            case 4:
                SelectStagestageB = "ステージ４";
                Debug.Log(SelectStagestageB);
                SelectStagestageB_num_num = 4;
                sColor();
                SS();
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
        stageC[0].GetComponent<Image>().color = Color.white;
        stageC[1].GetComponent<Image>().color = Color.white;
        stageC[2].GetComponent<Image>().color = Color.white;
        switch (lsNumber)
        {
            case 0:
                stageC[0].GetComponent<Image>().color = Color.red;
                break;
            case 1:
                stageC[1].GetComponent<Image>().color = Color.green;
                break;
            case 2:
                stageC[2].GetComponent<Image>().color = Color.blue;
                break;
        }
    }
    public void CQColor()
    {
        stageSQ[0].GetComponent<Image>().color = Color.white;
        stageSQ[1].GetComponent<Image>().color = Color.white;
        stageSQ[2].GetComponent<Image>().color = Color.white;
        stageSQ[3].GetComponent<Image>().color = Color.white;
        stageSQ[4].GetComponent<Image>().color = Color.white;
        if(lsNumber == 0)
        {
            switch (SelectOn)
            {
                case "EP.1":
                    stageSQ[0].GetComponent<Image>().color = Color.red;
                    break;
                case "EP.2":
                    stageSQ[1].GetComponent<Image>().color = Color.red;
                    break;
                case "EP.3":
                    stageSQ[2].GetComponent<Image>().color = Color.red;
                    break;
                case "EP.4":
                    stageSQ[3].GetComponent<Image>().color = Color.red;
                    break;
                case "EP.5":
                    stageSQ[4].GetComponent<Image>().color = Color.red;
                    break;
            }
        }
        else if(lsNumber == 1)
        {
            switch (SelectOn)
            {
                case "EP.1":
                    stageSQ[0].GetComponent<Image>().color = Color.green;
                    break;
                case "EP.2":
                    stageSQ[1].GetComponent<Image>().color = Color.green;
                    break;
                case "EP.3":
                    stageSQ[2].GetComponent<Image>().color = Color.green;
                    break;
                case "EP.4":
                    stageSQ[3].GetComponent<Image>().color = Color.green;
                    break;
                case "EP.5":
                    stageSQ[4].GetComponent<Image>().color = Color.green;
                    break;
            }
        }
        else if(lsNumber == 2)
        {
            switch (SelectOn)
            {
                case "EP.1":
                    stageSQ[0].GetComponent<Image>().color = Color.blue;
                    break;
                case "EP.2":
                    stageSQ[1].GetComponent<Image>().color = Color.blue;
                    break;
                case "EP.3":
                    stageSQ[2].GetComponent<Image>().color = Color.blue;
                    break;
                case "EP.4":
                    stageSQ[3].GetComponent<Image>().color = Color.blue;
                    break;
                case "EP.5":
                    stageSQ[4].GetComponent<Image>().color = Color.blue;
                    break;
            }
        }
    }
    public void sColor()
    {
        stage[0].GetComponent<Image>().color = Color.white;
        stage[1].GetComponent<Image>().color = Color.white;
        stage[2].GetComponent<Image>().color = Color.white;
        stage[3].GetComponent<Image>().color = Color.white;
        if(lsNumber == 0)
        {
            switch (SelectStagestageB)
            {
                case "ステージ1":
                    stage[0].GetComponent<Image>().color = Color.red;
                    break;
                case "ステージ２":
                    stage[1].GetComponent<Image>().color = Color.red;
                    break;
                case "ステージ３":
                    stage[2].GetComponent<Image>().color = Color.red;
                    break;
                case "ステージ４":
                    stage[3].GetComponent<Image>().color = Color.red;
                    break;
            }
        }
        else if(lsNumber == 1)
        {
            switch (SelectStagestageB)
            {
                case "ステージ1":
                    stage[0].GetComponent<Image>().color = Color.green;
                    break;
                case "ステージ２":
                    stage[1].GetComponent<Image>().color = Color.green;
                    break;
                case "ステージ３":
                    stage[2].GetComponent<Image>().color = Color.green;
                    break;
                case "ステージ４":
                    stage[3].GetComponent<Image>().color = Color.green;
                    break;
            }
        }
        else if(lsNumber == 2) 
        { 
            switch (SelectStagestageB)
            {
                case "ステージ1":
                    stage[0].GetComponent<Image>().color = Color.blue;
                    break;
                case "ステージ２":
                    stage[1].GetComponent<Image>().color = Color.blue;
                    break;
                case "ステージ３":
                    stage[2].GetComponent<Image>().color = Color.blue;
                    break;
                case "ステージ４":
                    stage[3].GetComponent<Image>().color = Color.blue;
                    break;
            }
        }
    }
    public void DifColor()
    {
        Difficulty[0].GetComponent<Image>().color = Color.white;
        Difficulty[1].GetComponent<Image>().color = Color.white;
        Difficulty[2].GetComponent<Image>().color = Color.white;
        if(lsNumber == 0)
        {
            switch (Difdifficulty)
            {
                case "イージー":
                    Difficulty[0].GetComponent<Image>().color = Color.red;
                    break;
                case "ノーマル":
                    Difficulty[1].GetComponent<Image>().color = Color.red;
                    break;
                case "ハード":
                    Difficulty[2].GetComponent<Image>().color = Color.red;
                    break;
            }
        }
        else if (lsNumber == 1)
        {
            switch (Difdifficulty)
            {
                case "イージー":
                    Difficulty[0].GetComponent<Image>().color = Color.green;
                    break;
                case "ノーマル":
                    Difficulty[1].GetComponent<Image>().color = Color.green;
                    break;
                case "ハード":
                    Difficulty[2].GetComponent<Image>().color = Color.green;
                    break;
            }
        }
        else if (lsNumber == 2)
        {
            switch (Difdifficulty)
            {
                case "イージー":
                    Difficulty[0].GetComponent<Image>().color = Color.blue;
                    break;
                case "ノーマル":
                    Difficulty[1].GetComponent<Image>().color = Color.blue;
                    break;
                case "ハード":
                    Difficulty[2].GetComponent<Image>().color = Color.blue;
                    break;
            }
        }
    }
    public void SS()
    {
    }
        /*SelectOnClick(SelectOn_num);
        SelectStagestageB_num(SelectStagestageB_num_num);
        switch (sNumber)
        {
            case 0:
                switch (SelectOn_num)
                {
                    case 1:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[0] += 1;
                                if (ep[0] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[1] += 1;
                                if (ep[1] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[2] += 1;
                                if (ep[2] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[3] += 1;
                                if (ep[3] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 2:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[4] += 1;
                                if (ep[4] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[5] += 1;
                                if (ep[5] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[6] += 1;
                                if (ep[6] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[7] += 1;
                                if (ep[7] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 3:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[8] += 1;
                                if (ep[8] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[9] += 1;
                                if (ep[9] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[10] += 1;
                                if (ep[10] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[11] += 1;
                                if (ep[11] == 1)
                                {
                                   stage_num[sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[12] += 1;
                                if (ep[12] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[13] += 1;
                                if (ep[13] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[14] += 1;
                                if (ep[14] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[15] += 1;
                                if (ep[15] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 5:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[16] += 1;
                                if (ep[16] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[17] += 1;
                                if (ep[17] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[18] += 1;
                                if (ep[18] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[19] += 1;
                                if (ep[19] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                }
                break;
            case 1:
                switch (SelectOn_num)
                {
                    case 1:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[20] += 1;
                                if (ep[20] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[21] += 1;
                                if (ep[21] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[22] += 1;
                                if (ep[22] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[23] += 1;
                                if (ep[23] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 2:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[24] += 1;
                                if (ep[24] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[25] += 1;
                                if (ep[25] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[26] += 1;
                                if (ep[26] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[27] += 1;
                                if (ep[27] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 3:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[28] += 1;
                                if (ep[28] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[29] += 1;
                                if (ep[29] == 1)
                                {
                                   stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[30] += 1;
                                if (ep[30] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[31] += 1;
                                if (ep[31] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[32] += 1;
                                if (ep[32] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[33] += 1;
                                if (ep[33] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[34] += 1;
                                if (ep[34] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[35] += 1;
                                if (ep[35] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[36] += 1;
                                if (ep[36] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[37] += 1;
                                if (ep[37] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[38] += 1;
                                if (ep[38] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[39] += 1;
                                if (ep[39] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                }
                break;
            case 2:

                switch (SelectOn_num)
                {
                    case 1:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[40] += 1;
                                if (ep[40] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[41] += 1;
                                if (ep[41] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[42] += 1;
                                if (ep[42] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[43] += 1;
                                if (ep[43] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 2:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[44] += 1;
                                if (ep[44] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[45] += 1;
                                if (ep[45] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[46] += 1;
                                if (ep[46] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[47] += 1;
                                if (ep[47] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 3:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[48] += 1;
                                if (ep[48] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[49] += 1;
                                if (ep[49] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[50] += 1;
                                if (ep[50] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[51] += 1;
                                if (ep[51] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[52] += 1;
                                if (ep[52] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[53] += 1;
                                if (ep[53] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[54] += 1;
                                if (ep[54] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[55] += 1;
                                if (ep[55] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 5:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[56] += 1;
                                if (ep[56] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 2:
                                ep[57] += 1;
                                if (ep[57] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 3:
                                ep[58] += 1;
                                if (ep[58] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                            case 4:
                                ep[59] += 1;
                                if (ep[59] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                        }
                        break;
                }
                break;
        }
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
    }*/
}

>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
