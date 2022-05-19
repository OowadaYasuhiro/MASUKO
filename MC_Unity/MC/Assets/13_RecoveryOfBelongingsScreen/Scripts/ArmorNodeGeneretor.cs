using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorNodeGeneretor : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    /// <summary>
    /// ノードの生成処理
    /// </summary>

<<<<<<< HEAD
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    [SerializeField]
    private GameObject nodePrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
<<<<<<< HEAD
<<<<<<< HEAD
    private Sprite[] artifactsImages;
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
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.red, "Akatuki"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1],Color.red,"Akatuki"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2],Color.red,"Akatuki"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.green, "Yujyou"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.green, "Yujyou"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.green, "Yujyou"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.blue, "Rekisen"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.blue, "Rekisen"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.blue, "Rekisen"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.magenta, "Onnnen"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.magenta, "Onnnen"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.magenta, "Onnnen"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.yellow, "Hua"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.yellow, "Hua"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.yellow, "Hua"));

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
=======
    private int testNodeAmount;
=======
    private Sprite[] artifactsImages;
    [SerializeField]
    private bool isDebug;
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

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
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.red, "Akatuki"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1],Color.red,"Akatuki"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2],Color.red,"Akatuki"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.green, "Yujyou"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.green, "Yujyou"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.green, "Yujyou"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.blue, "Rekisen"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.blue, "Rekisen"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.blue, "Rekisen"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.magenta, "Onnnen"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.magenta, "Onnnen"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.magenta, "Onnnen"));
                testCrownArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.yellow, "Hua"));
                testBangleArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.yellow, "Hua"));
                testRingArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.yellow, "Hua"));

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

<<<<<<< HEAD
        for (var i = 0; i < testNodeAmount; i++)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
    private void GenerateNodes(List<Artifact> artifacts,int selectedLeft,int selectedRight)
    {
        for (var i = 0; i < artifacts.Count; i++)
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        {
            node = Instantiate(nodePrefab);
            node.transform.SetParent(content);
            node.transform.localScale = new Vector3(1f, 1f, 1f);
            node.transform.localRotation = Quaternion.identity;
            node.transform.localPosition = Vector3.zero;
            node.GetComponent<NodeMain>().SetNodeIndex(i);

<<<<<<< HEAD
<<<<<<< HEAD
            node.GetComponentInChildren<Text>().text = "Lv" + artifacts[i].GetLevel().ToString();
            node.GetComponent<Image>().sprite = artifacts[i].GetIcon();

            if (node.GetComponent<NodeMain>().GetNodeIndex() == selectedLeft || node.GetComponent<NodeMain>().GetNodeIndex() == selectedRight)
            {
                node.GetComponent<Image>().color = Color.gray;
                node.GetComponent<Button>().enabled = false;
            }
            else
            {
                node.GetComponent<Image>().color = artifacts[i].GetColor();
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
=======
            node.GetComponent<Image>().color = testColors[i];
=======
            node.GetComponentInChildren<Text>().text = "Lv" + artifacts[i].GetLevel().ToString();
            node.GetComponent<Image>().sprite = artifacts[i].GetIcon();
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

            if (node.GetComponent<NodeMain>().GetNodeIndex() == selectedLeft || node.GetComponent<NodeMain>().GetNodeIndex() == selectedRight)
            {
                node.GetComponent<Image>().color = Color.gray;
                node.GetComponent<Button>().enabled = false;
            }
            else
            {
                node.GetComponent<Image>().color = artifacts[i].GetColor();
            }
        }
    }
<<<<<<< HEAD
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======

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
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
}
