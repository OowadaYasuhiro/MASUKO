using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaikai : MonoBehaviour
{
    int tmp;
    int nowduplication;
    [SerializeField] GameObject u1;
    [SerializeField] GameObject u2;
    [SerializeField] GameObject u3;
    [SerializeField] GameObject u4;
    [SerializeField] GameObject s1;
    [SerializeField] GameObject s2;
    [SerializeField] GameObject s3;
    [SerializeField] GameObject s4;
    [SerializeField] Text ut1;
    [SerializeField] Text st1;
    // Start is called before the first frame update
    void OnEnable()
    {
        u1.gameObject.SetActive(false);
        u2.gameObject.SetActive(false);
        u3.gameObject.SetActive(false);
        u4.gameObject.SetActive(false);
        s1.gameObject.SetActive(false);
        s2.gameObject.SetActive(false);
        s3.gameObject.SetActive(false);
        s4.gameObject.SetActive(false);
        zyougen(Master.playerdeta.NowSelectCharactor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void zyougen(string i){
        switch(i) {
            case "Ghost":
                nowduplication = Master.playerdeta.Ghostduplication;
                a(Master.playerdeta.GhostPotentialflowering);
                switch(tmp) {
                    case 0:
                        ut1.text="・なし";
                        st1.text = "Atk+50\n再配置-10秒";
                        break;
                    case 1:
                        ut1.text = "Atk+50\n再配置-10秒";
                        st1.text = "Atk+50\n再配置-10秒\nパッシブスキル+1";
                        break;
                    case 2:
                        ut1.text = "Atk+50\n再配置-10秒\nパッシブスキル+1";
                        st1.text = "Atk+50\n再配置-10秒\nパッシブスキル+2";
                        break;
                    case 3:
                        ut1.text = "Atk+50\n再配置-10秒\nパッシブスキル+2";
                        st1.text = "Atk+100\n再配置-10秒\nパッシブスキル+2\n攻撃速度上昇0.8s";
                        break;
                    case 4:
                        ut1.text = "Atk+100\n再配置-10秒\nパッシブスキル+2\n攻撃速度上昇0.8s";
                        st1.text = "--";
                        break;
                }
                break;
            case "Zashiki_warashi":
                nowduplication = Master.playerdeta.Zashiki_warashiduplication;
                a(Master.playerdeta.Zashiki_warashiPotentialflowering);
                switch(tmp) {
                    case 0:
                        ut1.text = "・なし";
                        st1.text = "Def+50\n再配置-10ｓ";
                        break;
                    case 1:
                        ut1.text = "Def+50\n再配置-10ｓ";
                        st1.text = "Def+50\n再配置-10ｓ\nパッシブスキル+1";
                        break;
                    case 2:
                        ut1.text = "Def+50\n再配置-10ｓ\nパッシブスキル+1";
                        st1.text = "Def+50\n再配置-10ｓ\nパッシブスキル+2";
                        break;
                    case 3:
                        ut1.text = "Def+50\n再配置-10ｓ\nパッシブスキル+2";
                        st1.text = "Def+100\n再配置-10ｓ\nパッシブスキル+2\nクールダウン-1";
                        break;
                    case 4:
                        ut1.text = "Def+100\n再配置-10ｓ\nパッシブスキル+2\nクールダウン-1";
                        st1.text = "--";
                        break;
                }
                break;
            case "Gore":
                nowduplication = Master.playerdeta.goreduplication;
                a(Master.playerdeta.GorePotentialflowering);
                switch(tmp) {
                    case 0:
                        ut1.text = "・なし";
                        st1.text = "ＨＰ+100\n再配置-10ｓ";
                        break;
                    case 1:
                        ut1.text = "ＨＰ+100\n再配置-10ｓ";
                        st1.text = "ＨＰ+100\n再配置-10ｓ\nパッシブスキル+1";
                        break;
                    case 2:
                        ut1.text = "ＨＰ+100\n再配置-10ｓ\nパッシブスキル+1";
                        st1.text = "ＨＰ+100\n再配置-10ｓ\nパッシブスキル+2";
                        break;
                    case 3:
                        ut1.text = "ＨＰ+100\n再配置-10ｓ\nパッシブスキル+2";
                        st1.text = "ＨＰ+150\n再配置-10ｓ\nパッシブスキル+2\nDef+50\n再配置10秒";
                        break;
                    case 4:
                        ut1.text = "ＨＰ+150\n再配置-10ｓ\nパッシブスキル+2\nDef+50\n再配置10秒";
                        st1.text = "--";
                        break;
                }
                break;
            case "Poltergeist":
                nowduplication = Master.playerdeta.Poltergeistduplication;
                a(Master.playerdeta.PoltergeistPotentialflowering);
                switch(tmp) {
                    case 0:
                        ut1.text = "・なし";
                        st1.text = "Atk+25\n体力+100";
                        break;
                    case 1:
                        ut1.text = "Atk+25\n体力+100";
                        st1.text = "Atk+25\n体力+100\nパッシブスキル+1";
                        break;
                    case 2:
                        ut1.text = "Atk+25\n体力+100\nパッシブスキル+1";
                        st1.text = "Atk+25\n体力+100\nパッシブスキル+2";
                        break;
                    case 3:
                        ut1.text = "Atk+25\n体力+100\nパッシブスキル+2";
                        st1.text = "Atk+25\n体力+100\nパッシブスキル+2\nAtk+50\nスキルクールダウン-1s";
                        break;
                    case 4:
                        ut1.text = "Atk+25\n体力+100\nパッシブスキル+2\nAtk+50\nスキルクールダウン-1s";
                        st1.text = "--";
                        break;
                }
                break;
            case "Daemon":
                nowduplication = Master.playerdeta.Daemonduplication;
                a(Master.playerdeta.DaemonPotentialflowering);
                switch(tmp) {
                    case 0:
                        ut1.text = "・なし";
                        st1.text = "Atk+50\n再配置-10s";
                        break;
                    case 1:
                        ut1.text = "Atk+50\n再配置-10s";
                        st1.text = "Atk+50\n再配置-10s\nパッシブスキル+1";
                        break;
                    case 2:
                        ut1.text = "Atk+50\n再配置-10s\nパッシブスキル+1";
                        st1.text = "Atk+50\n再配置-10s\nパッシブスキル+2";
                        break;
                    case 3:
                        ut1.text = "Atk+50\n再配置-10s\nパッシブスキル+2";
                        st1.text = "Atk+150\n再配置-10s\nパッシブスキル+2";
                        break;
                    case 4:
                        ut1.text = "Atk+150\n再配置-10s\nパッシブスキル+2";
                        st1.text = "--";
                        break;
                }
                break;
        }
    }
    void a(int i) {
        switch(i){
        case 0:
                tmp = 0;
                        s1.gameObject.SetActive(true);
                        break;
        case 1:
                tmp = 1;
                        u1.gameObject.SetActive(true);
                        s1.gameObject.SetActive(true);
                        s2.gameObject.SetActive(true);
                        break;
        case 2:
                tmp = 2;
                        u1.gameObject.SetActive(true);
                        u2.gameObject.SetActive(true);
                        s1.gameObject.SetActive(true);
                        s2.gameObject.SetActive(true);
                        s3.gameObject.SetActive(true);
                        break;
        case 3:
                tmp = 3;
                        u1.gameObject.SetActive(true);
                        u2.gameObject.SetActive(true);
                        u3.gameObject.SetActive(true);
                        s1.gameObject.SetActive(true);
                        s2.gameObject.SetActive(true);
                        s3.gameObject.SetActive(true);
                        s4.gameObject.SetActive(true);
                        break;
        case 4:
                tmp = 4;
                        u1.gameObject.SetActive(true);
                        u2.gameObject.SetActive(true);
                        u3.gameObject.SetActive(true);
                        u4.gameObject.SetActive(true);
                        s1.gameObject.SetActive(true);
                        s2.gameObject.SetActive(true);
                        s3.gameObject.SetActive(true);
                        s4.gameObject.SetActive(true);
                        break;
        }
    }
    public void OnClick() {
        if(tmp <4 && nowduplication <= 1) {
            switch(Master.playerdeta.NowSelectCharactor) {
                case "Ghost":
                    Master.playerdeta.Ghostduplication--;
                    Master.playerdeta.GhostPotentialflowering++;
                    break;
                case "Zashiki_warashi":
                    Master.playerdeta.Zashiki_warashiduplication--;
                    Master.playerdeta.Zashiki_warashiPotentialflowering++;
                    break;
                case "Gore":
                    Master.playerdeta.goreduplication--;
                    Master.playerdeta.GorePotentialflowering++;
                    break;
                case "Poltergeist":
                    Master.playerdeta.Poltergeistduplication--;
                    Master.playerdeta.PoltergeistPotentialflowering++;
                    break;
                case "Daemon":
                    Master.playerdeta.Daemonduplication --;
                    Master.playerdeta.DaemonPotentialflowering ++;
                    break;
            }
            zyougen(Master.playerdeta.NowSelectCharactor);
        }
    }
}


