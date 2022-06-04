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
    public Text[] textQ_;
    [SerializeField]
    public Text[] textQ;
    //[SerializeField]
    //public Text[] textDifficulty;
    //ボタンオブジェクト
    [SerializeField]
    private GameObject[] stageDay;
    [SerializeField]
    private GameObject[] stageEX;
    [SerializeField]
    private GameObject[] stageEP;
    [SerializeField]
    private GameObject[] objGetQ_;
    public Text[] textStage;
    [SerializeField]
    public Text[] textLQN;
    [SerializeField]
    public Text[] textQN;
    
    [SerializeField]
    public Text FCSQtext;
    [SerializeField]
    public Text FCRLtext;
    [SerializeField]
    public Text FCStext;
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
    public GameObject back;
    [SerializeField]
    public GameObject targetObj;
    FinalConfirmationScreen ss;


    [SerializeField]
    public Image stageimages;
    public int[] ep;
    public Sprite[] imagesS;

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
    private int SelectStagestageB_num_num;
    private int SelectOn_num;
   // var colors;

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
        //PlayerPrefs.GetInt("SCORE", 0);
        Selectstage(0);
        //SelectOnClick(1);
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
    }

    // Update is called once per frame
    void Update()
    {
        Selectstage_num();
        Selectlstage_num();
    }

    /*public void OnClick()
    {
        stage_num[sNumber]++;
        Debug.Log(stage_num[sNumber] + "成功！！");
        if (stage_num[sNumber] % 5 == 0)
        {
            lstage_num[lsNumber]++;
            stage_num[sNumber] = 1;
        }
        Debug.Log(lstage_num[lsNumber]);
    }*/

    public void BackButton()
    {
        Debug.Log("Back");
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
                //SelectStagestageB_num(1);
                CColor();
                DifColor();
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
                //SelectStagestageB_num(1);
                CColor();
                DifColor();
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
                //SelectStagestageB_num(1);
                CColor();
                DifColor();
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
        for (int i = 0; i <= textQ_.Length; i++)
        {

            if (i <= 3)
            {
                textQ_[i].text = textAbbreviation + "." + st + "-" + j;
                j++;
            }
            else if (i >= 4 && i <= 6)
            {
                textQ_[i].text = textAbbreviation + "." + st + "-" + (j - 3);
                j++;
            }

        }
    }

    public void SelectStage_numfalse()
    {
        objGetQ_[0].SetActive(false);
        objGetQ_[1].SetActive(false);
        objGetQ_[2].SetActive(false);
    }

    public void SelectStage_numtrue()
    {
        objGetQ_[0].SetActive(true);
        objGetQ_[1].SetActive(true);
        objGetQ_[2].SetActive(true);
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
            objGetQ_[0].SetActive(false);
        }

        if (stage_num[sNumber] >= 3)
        {
            objGetQ_[1].SetActive(false);
        }

        if (stage_num[sNumber] >= 4)
        {
            objGetQ_[2].SetActive(false);
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
                difficulty_num = 1;
                DifColor();
                break;
            case　2:
                Difdifficulty = "ノーマル";
                difficulty_num = 2;
                DifColor();
                break;
            case 3:
                Difdifficulty = "ハード";
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
                SelectStagestageB_num_num = 1;
                sColor();
                FCSText();
                break;
            case 2:
                SelectStagestageB = "ステージ２";
                SelectStagestageB_num_num = 2;
                sColor();
                FCSText();
                break;
            case 3:
                SelectStagestageB = "ステージ３";
                SelectStagestageB_num_num = 3;
                sColor();
                FCSText();
                break;
            case 4:
                SelectStagestageB = "ステージ４";
                SelectStagestageB_num_num = 4;
                sColor();
                FCSText();
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
                //SS();
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
                QuestOn = "デイリークエスト";
                break;
            case 3:
                QuestOn = "イベントクエスト";
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

    //ステージクリアの合計を計測
    public void SS()
    {
        int ss_num = sNumber * 20 + (SelectOn_num - 1) * 4 + (SelectStagestageB_num_num - 1);
        switch (sNumber)
        {
            case 0:
            case 1:
            case 2:
                switch (SelectOn_num)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                ep[ss_num] += 1;
                                if (ep[ss_num] == 1)
                                {
                                    stage_num[sNumber]++;
                                }
                                break;
                        }
                        break;
                }
                break;
        }
        if (stage_num[sNumber] % 5 == 0)
        {
            lstage_num[lsNumber]++;
            stage_num[sNumber] = 1;
        }
        Debug.Log(SelectOn);
        Debug.Log(SelectStagestageB);
        Debug.Log(Difdifficulty);
    }

    public void FCSText()
    {
        FCSQtext.text = textAbbreviation + "." + SelectOn_num + "-" + SelectStagestageB_num_num;
        FCRLtext.text = "推奨レベル" + SelectStagestageB;
        FCStext.text = "人間が2か所から出現するという情報を入手した人間の行動パターンも書類にまとめて送信するあとで眼を投資手おいてくれ　この地域は足の速い人間が多く出現するようだ気を付けて戦いに臨んでくれ" + SelectStagestageB_num_num;
        int ss_num = sNumber * 20 + (SelectOn_num - 1) * 4 + (SelectStagestageB_num_num - 1);
        switch (sNumber)
        {
            case 0:
            case 1:
            case 2:
                switch (SelectOn_num)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        switch (SelectStagestageB_num_num)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                stageimages.sprite = imagesS[ss_num];
                                break;
                        }
                        break;
                }
                break;
        }
    }

    public int QuestNumber
    {
        get{ return this.sNumber; }
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
