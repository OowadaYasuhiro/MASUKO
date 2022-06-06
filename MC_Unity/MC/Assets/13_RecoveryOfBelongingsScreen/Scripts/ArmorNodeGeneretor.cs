using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorNodeGeneretor : MonoBehaviour
{
    /// <summary>
    /// ノードの生成処理
    /// </summary>

    [SerializeField]
    private GameObject nodePrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private Sprite[] huaImages;
    [SerializeField]
    private Sprite[] onnnenImages;
    [SerializeField]
    private Sprite[] rekisenImages;
    [SerializeField]
    private Sprite[] yujyouImages;
    [SerializeField]
    private Sprite[] akatukiImages;


    [SerializeField]
    private bool isDebug;

    //Debug用
    private static bool isLoad = false;
    private static List<Artifact> testCrownArtifacts = new List<Artifact>();
    private static List<Artifact> testBangleArtifacts = new List<Artifact>();
    private static List<Artifact> testRingArtifacts = new List<Artifact>();

    public static int character1SelectedCrownNum = -1;
    public static int character1SelectedBangleNum = -1;
    public static int character1SelectedRingNum = -1;

    public static int character2SelectedCrownNum = -1;
    public static int character2SelectedBangleNum = -1;
    public static int character2SelectedRingNum = -1;

    private GameObject node;
    private RecoveryOfBelongingsScreen_Deta data = new RecoveryOfBelongingsScreen_Deta();

    private void Awake()
    {
        if (isDebug)
        {
            if (!isLoad)
            {
                testCrownArtifacts.Add(data.InstantiateCrown(huaImages[0], "Hua"));
                testBangleArtifacts.Add(data.InstantiateBangle(huaImages[1], "Hua"));
                testRingArtifacts.Add(data.InstantiateRing(huaImages[2], "Hua"));
                testCrownArtifacts.Add(data.InstantiateCrown(onnnenImages[0], "Onnnen"));
                testBangleArtifacts.Add(data.InstantiateBangle(onnnenImages[1], "Onnnen"));
                testRingArtifacts.Add(data.InstantiateRing(onnnenImages[2], "Onnnen"));
                testCrownArtifacts.Add(data.InstantiateCrown(rekisenImages[0], "Rekisen"));
                testBangleArtifacts.Add(data.InstantiateBangle(rekisenImages[1], "Rekisen"));
                testRingArtifacts.Add(data.InstantiateRing(rekisenImages[2], "Rekisen"));
                testCrownArtifacts.Add(data.InstantiateCrown(yujyouImages[0], "Yujyou"));
                testBangleArtifacts.Add(data.InstantiateBangle(yujyouImages[1], "Yujyou"));
                testRingArtifacts.Add(data.InstantiateRing(yujyouImages[2], "Yujyou"));
                testCrownArtifacts.Add(data.InstantiateCrown(akatukiImages[0], "Akatuki"));
                testBangleArtifacts.Add(data.InstantiateBangle(akatukiImages[1], "Akatuki"));
                testRingArtifacts.Add(data.InstantiateRing(akatukiImages[2], "Akatuki"));

                isLoad = true;
            }
            switch (OrganizationScreen_Deta.armorNum)
            {
                case 0:
                case 3:
                    GenerateNodes(testCrownArtifacts, character1SelectedCrownNum, character2SelectedCrownNum);
                    break;
                case 1:
                case 4:
                    GenerateNodes(testBangleArtifacts, character1SelectedBangleNum, character2SelectedBangleNum);
                    break;
                case 2:
                case 5:
                    GenerateNodes(testRingArtifacts, character1SelectedRingNum, character2SelectedRingNum);
                    break;
                default:
                    Debug.LogError("Illegal Value");
                    break;
            }
        }
        else
        {
            //todo 現在所持している遺物数の取得
        }
    }

    private void GenerateNodes(List<Artifact> artifacts,int selectedLeft,int selectedRight)
    {
        for (var i = 0; i < artifacts.Count; i++)
        {
            node = Instantiate(nodePrefab);
            node.transform.SetParent(content);
            node.transform.localScale = new Vector3(1f, 1f, 1f);
            node.transform.localRotation = Quaternion.identity;
            node.transform.localPosition = Vector3.zero;
            node.GetComponent<NodeMain>().SetNodeIndex(i);

            node.GetComponentInChildren<Text>().text = "Lv" + artifacts[i].GetLevel().ToString();
            node.GetComponent<Image>().sprite = artifacts[i].GetIcon();

            if (node.GetComponent<NodeMain>().GetNodeIndex() == selectedLeft || node.GetComponent<NodeMain>().GetNodeIndex() == selectedRight)
            {
                node.GetComponent<Image>().color = Color.gray;
                node.GetComponent<Button>().enabled = false;
            }
            else
            {
                node.GetComponent<Image>().color = Color.white;
            }
        }
    }

    public static Artifact GetCrownArtifact(int index)
    {
        return testCrownArtifacts[index];
    }

    public static Artifact GetBangleArtifact(int index)
    {
        return testBangleArtifacts[index];
    }

    public static Artifact GetRingArtifact(int index)
    {
        return testRingArtifacts[index];
    }
}
