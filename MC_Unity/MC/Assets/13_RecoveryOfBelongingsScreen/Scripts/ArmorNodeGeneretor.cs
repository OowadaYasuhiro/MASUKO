using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorNodeGeneretor : MonoBehaviour
{
    [SerializeField]
    private GameObject nodePrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private int testNodeAmount;

    private GameObject node;

    void Start()
    {
        for (var i = 0; i < testNodeAmount; i++)
        {
            node = Instantiate(nodePrefab);
            node.transform.SetParent(content);
            node.transform.localScale = new Vector3(1f, 1f, 1f);
            node.transform.localPosition = Vector3.zero;
        }
    }
}
