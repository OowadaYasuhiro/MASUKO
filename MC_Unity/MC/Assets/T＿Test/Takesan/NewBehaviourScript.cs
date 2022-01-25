using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    ulong a = 10000000000000000000;
    double b = 10000000000000000000;
    //これだめ
    [SerializeField] public int c { get { return c; } set { int min = 1; int max = 20; c = Mathf.Clamp(value, min, max); } }
    [SerializeField]
    public int d;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
        Debug.Log(b*b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Test")]
    public void Test()
    {
        c = 0;
        d = c;
    }
}
