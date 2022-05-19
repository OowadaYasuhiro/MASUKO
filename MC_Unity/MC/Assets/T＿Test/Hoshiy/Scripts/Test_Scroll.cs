using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Scroll : MonoBehaviour
{
    [SerializeField]
    private GameObject node;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private int makeNodeAmount;

    private GameObject generateNode;

    void Start()
    {
        for (var i = 0; i < makeNodeAmount; i++)
        {
            generateNode = Instantiate(node, Vector3.zero, Quaternion.identity);
            generateNode.transform.SetParent(content);
        }
    }

    void Update()
    {
        
    }

    
}
