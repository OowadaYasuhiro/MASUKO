using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorNodeGeneretor : MonoBehaviour
{
    [SerializeField]
    private GameObject nodePrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private int testNodeAmount;

    private GameObject node;

    private int atrifactAmount;

    private List<GameObject> nodes = new List<GameObject>();

    private Color[] testColors = {Color.red, Color.green,Color.blue,Color.cyan, Color.magenta, Color.yellow};

    void Start()
    {
        //todo: 現在所持している遺物数の取得

        for (var i = 0; i < testNodeAmount; i++)
        {
            node = Instantiate(nodePrefab);
            node.transform.SetParent(content);
            node.transform.localScale = new Vector3(1f, 1f, 1f);
            node.transform.localRotation = Quaternion.identity;
            node.transform.localPosition = Vector3.zero;
            node.GetComponent<NodeMain>().SetNodeIndex(i);

            node.GetComponent<Image>().color = testColors[i];

            nodes.Add(node);
        }
    }
}
