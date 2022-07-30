using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resulttest : MonoBehaviour
{
    [SerializeField]
    private Text commen;
    [SerializeField]
    private Text characterName;
    [SerializeField]
    private Image character;
    [SerializeField]
    private Sprite[] characterUiSelectDaemon;
    [SerializeField]
    private Sprite[] characterUiSelectPoltergeist;
    [SerializeField]
    private Sprite[] characterUiSelectGore;
    [SerializeField]
    private Sprite[] characterUiSelectZashiki_warashi;
    [SerializeField]
    private Sprite[] characterUiSelectGhost;
    [SerializeField]
    public string[] selectCharactorDaemonCommen = { "今回は割とよかったんじゃない？\n蟲さんたちも喜んでる。" , 
        "まぁまぁ疲れたね。\n早く帰って休もうよ？" , "蟲さんたちありがとう。", "面白くなかった。もういい。" };
    [SerializeField]
    public string[] selectCharactorPoltergeistCommen = { "よかったみんなに何もなくて。\nテディもありがとう",
        "ちょっと怪我しちゃったけど大丈夫だよね。\nよかった。", "やっぱり人間は怖いな…\nテディ怖いよ。","ごめんなさい、ごめんなさい、ごめんなさい…"};
    [SerializeField]
    public string[] selectCharactorGoreCommen = {"力の差は歴然だな。", "悪くはなかろう", "精進せねば……。", "ぬかったか……。"};
    [SerializeField]
    public string[] selectCharactorZashiki_warashiCommen = { "まぁ私がいるのなら当然の結果ね。" , 
        "次のことを考えなさい。\nまぁでも悪くはないんじゃない。", "できることならもっと最善を尽くしなさい。" ,"あきれたわ。帰るわよ"};
    [SerializeField]
    public string[] selectCharactoGhostCommen = { "今回は最高だったわ…\nあの人間の絶望に満ちた表情…最高。" , "もう終わり？\nまぁまぁかしらね。", 
        "つまらないわ。\nさっさと帰るわよ。" , "あなたはいったい何をやっていたの？\nあきれたわ。"};
    [SerializeField]
    public string[] characterNames = {"Daemon", "Poltergeis", "Gore", "Zashiki_warashi", "Ghost"};
    [SerializeField]
    public string test1;

    [SerializeField]
    public SoundManager voice;


    // Start is called before the first frame update
    void Start()
    {
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                commen.text = selectCharactoGhostCommen[0];
                character.sprite = characterUiSelectGhost[0];
                characterName.text = "NAME:" + characterNames[0];
                voice.PlayVoice(0);
                break;
            case "Zashiki_warashi":
                commen.text = selectCharactorZashiki_warashiCommen[0];
                character.sprite = characterUiSelectZashiki_warashi[0];
                characterName.text = "NAME:" + characterNames[0];
                voice.PlayVoice(4);
                break;
            case "Gore":
                commen.text = selectCharactorGoreCommen[0];
                character.sprite = characterUiSelectGore[0];
                characterName.text = "NAME:" + characterNames[0];
                voice.PlayVoice(8);
                break;
            case "Poltergeist":
                commen.text = selectCharactorPoltergeistCommen[0];
                character.sprite = characterUiSelectPoltergeist[0];
                characterName.text = "NAME:" + characterNames[0];
                voice.PlayVoice(12);
                break;
            case "Daemon":
                commen.text = selectCharactorDaemonCommen[0];
                character.sprite = characterUiSelectDaemon[0];
                characterName.text = "NAME:" + characterNames[0];
                voice.PlayVoice(16);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
