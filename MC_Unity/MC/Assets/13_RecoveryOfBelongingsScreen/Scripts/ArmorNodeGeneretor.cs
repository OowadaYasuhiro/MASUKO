using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ArmorNodeGeneretor : MonoBehaviour
{
    [SerializeField]
    private GameObject nodePrefab;
    [SerializeField]
    private Transform content;

    private GameObject node;

    private static bool didLoad = false;

    private static List<Artifact> testArtifacts = new List<Artifact>();
    private Artifact test1 = new Artifact("a", 1,Color.red);
    private Artifact test2 = new Artifact("b", 2,Color.green);
    private Artifact test3 = new Artifact("c", 3,Color.blue);
    private Artifact test4 = new Artifact("d", 4,Color.cyan);
    private Artifact test5 = new Artifact("e", 5,Color.magenta);
    private Artifact test6 = new Artifact("f", 6,Color.yellow);

    private void Awake()
    {

        if (didLoad)
        {
            ;
        }
        else
        {
            testArtifacts.Add(test1);
            testArtifacts.Add(test2);
            testArtifacts.Add(test3);
            testArtifacts.Add(test4);
            testArtifacts.Add(test5);
            testArtifacts.Add(test6);

            didLoad = true;
        }

        //todo: 現在所持している遺物数の取得
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
        }
    }

    public static Artifact GetArtifact(int index)
    {
        return testArtifacts[index];
    }
}
