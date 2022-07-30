using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultItem : MonoBehaviour
{
    [SerializeField]
    public GameObject[] itemObject;
    [SerializeField]
    public int itemNum;
    [SerializeField]
    private GameObject items;
    private GameObject obj;
    public float scole;

    /*[SerializeField]
    public Sprite[] itemImages;
    [SerializeField]*
    public Image itemImageses;*/
    // Start is called before the first frame update
    void Start()
    {
        Item();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Item()
    {
        for(int i = 0; i <= 0; i++) { 
            obj = (GameObject)Instantiate(itemObject[0], transform.localPosition, Quaternion.identity);
            obj.transform.SetParent(items.transform, false);
            obj = (GameObject)Instantiate(itemObject[1], transform.localPosition, Quaternion.identity);
            obj.transform.SetParent(items.transform, false);
            obj = (GameObject)Instantiate(itemObject[2], transform.localPosition, Quaternion.identity);
            obj.transform.SetParent(items.transform, false);
        }

    }
}
