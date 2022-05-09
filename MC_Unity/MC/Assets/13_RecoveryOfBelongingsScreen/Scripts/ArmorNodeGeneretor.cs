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
    private Sprite[] artifactsImages;
    [SerializeField]
    private bool isDebug;

    //Debug用
    private static bool isLoad = false;
    private static List<Artifact> testArtifacts = new List<Artifact>();

    private GameObject node;
    private RecoveryOfBelongingsScreen_Deta data = new RecoveryOfBelongingsScreen_Deta();

    private void Awake()
    {
        if (isDebug)
        {
            if (!isLoad)
            {
                testArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.red, "Akatuki"));
                testArtifacts.Add(data.InstantiateBangle(artifactsImages[1],Color.red,"Akatuki"));
                testArtifacts.Add(data.InstantiateRing(artifactsImages[2],Color.red,"Akatuki"));
                testArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.green, "Yujyou"));
                testArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.green, "Yujyou"));
                testArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.green, "Yujyou"));
                testArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.blue, "Rekisen"));
                testArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.blue, "Rekisen"));
                testArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.blue, "Rekisen"));
                testArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.magenta, "Onnnen"));
                testArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.magenta, "Onnnen"));
                testArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.magenta, "Onnnen"));
                testArtifacts.Add(data.InstantiateCrown(artifactsImages[0], Color.yellow, "Hua"));
                testArtifacts.Add(data.InstantiateBangle(artifactsImages[1], Color.yellow, "Hua"));
                testArtifacts.Add(data.InstantiateRing(artifactsImages[2], Color.yellow, "Hua"));

                isLoad = true;
            }
            for (var i = 0; i < testArtifacts.Count; i++)
            {
                node = Instantiate(nodePrefab);
                node.transform.SetParent(content);
                node.transform.localScale = new Vector3(1f, 1f, 1f);
                node.transform.localRotation = Quaternion.identity;
                node.transform.localPosition = Vector3.zero;
                node.GetComponent<NodeMain>().SetNodeIndex(i);

                node.GetComponentInChildren<Text>().text = "Lv" + testArtifacts[i].GetLevel().ToString();
                node.GetComponent<Image>().color = testArtifacts[i].GetColor();
                node.GetComponent<Image>().sprite = testArtifacts[i].GetIcon();
            }
        }
        else
        {
            //todo 現在所持している遺物数の取得
        }
    }

    public static Artifact GetArtifact(int index)
    {
        return testArtifacts[index];
    }
}
