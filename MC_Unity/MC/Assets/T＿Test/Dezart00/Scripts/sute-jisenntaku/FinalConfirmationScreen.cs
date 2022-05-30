using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalConfirmationScreen : MonoBehaviour
{
    [SerializeField]
    public GameObject[] source;
    [SerializeField]
    public GameObject[] star;
    [SerializeField]
    public GameObject[] back;
    [SerializeField]
    public Image[] stageimages;
    [SerializeField]
    public Image[] caractorimages;
    [SerializeField]
    public Image[] doropimages;
    [SerializeField]
    public Text FCSQtext;
    [SerializeField]
    public Text FCRLtext;
    [SerializeField]
    public Text FCStext;
    EP epScript;


    // Start is called before the first frame update
    void Start()
    {
        source[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FCScreendo()
    {
        source[0].SetActive(true);
    }

    public void FCScreendc()
    {
        source[0].SetActive(false);
    }

}
