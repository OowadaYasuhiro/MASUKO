using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultExperience : MonoBehaviour
{
    [SerializeField]
    public GameObject TextLvel;
    [SerializeField]
    public GameObject TextTotalExperience;
    [SerializeField]
    public GameObject skipButton;
    /*[SerializeField]
    public GameObject Item_object = null;
    [SerializeField]
    public int Item_num = 0;*/
    [SerializeField]
    public float TotalExperience;
    [SerializeField]
    public float Lv_num;
    [SerializeField]
    public Slider exSlider;
    private float speed = 0.01f;
    public Text TE_Lv;
    public Text Lv_text;
    private bool skip;

    void Awake()
    {
        /*TextLvel = null;
        TextTotalExperience = null;*/
        TotalExperience = 0;
        Lv_num = Master.playerdeta.PlayerLevel;
    }
    // Start is called before the first frame update
    void Start()
    {
        skip = false;

        //スライダーの最大値の設定
        exSlider.maxValue = Lv_num * 1000;

        StartCoroutine(ScoreAnimation(TotalExperience, TotalExperience + 200f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { //Down
            StartCoroutine(ScoreAnimation(TotalExperience, TotalExperience + 200f, 1f));
        }
        if (Master.playerdeta.PlayerExperience == TotalExperience)
        {
            Lv_num += 1;
            TotalExperience = 0;
        }
        //スライダーの現在値の設定
        exSlider.value = TotalExperience;
        TE_Lv.text = TotalExperience + "/" + Master.playerdeta.PlayerExperience;
        Lv_text.text = Lv_num + "";
        //スライダーの最大値の設定
        exSlider.maxValue = Lv_num * 1000;

        //Text Item_text = Item_object.GetComponent<Text>();
        //Item_text.text = "×" + Item_num;
    }

    // スコアをアニメーションさせる
    private IEnumerator ScoreAnimation(float startScore, float endScore, float duration)
    {

        // 開始時間
        float startTime = Time.time;

        // 終了時間
        float endTime = startTime + duration;

        do
        {
            // 現在の時間の割合
            float timeRate = (Time.time - startTime) / duration;

            // 数値を更新
            float updateValue = (float)((endScore - startScore) * timeRate + startScore);

            //updateValue = TotalExperience;

            // テキストの更新
            TE_Lv.text = updateValue.ToString("f0") + "/" + Master.playerdeta.PlayerExperience; // （"f0" の "0" は、小数点以下の桁数指定）

            //スライダーの現在値の設定
            exSlider.value = updateValue;




            // 1フレーム待つ
            yield return null;

            if (skip == true)
            {
                break;
            }

        } while (Time.time < endTime);

        // 最終的な着地のスコア
        TotalExperience = endScore;
        TE_Lv.text = TotalExperience.ToString();
        skipButton.SetActive(false);
    }
    
    public void Skipbutton()
    {
        skip = true;
        TotalExperience += 200;
        skipButton.SetActive(false);
    }
}
