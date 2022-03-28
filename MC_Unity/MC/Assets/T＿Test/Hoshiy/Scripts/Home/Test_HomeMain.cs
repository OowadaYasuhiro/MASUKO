using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_HomeMain : MonoBehaviour
{
    [SerializeField]
    private GameObject playerLevel;
    [SerializeField]
    private GameObject playerName;
    [SerializeField]
    private GameObject playerGauge;
    [SerializeField]
    private GameObject gatyaText;
    [SerializeField]
    private GameObject expText;
    [SerializeField]
    private GameObject moneyText;
    [SerializeField]
    private GameObject messageWindow;
    [SerializeField]
    private GameObject characterName;
    [SerializeField]
    private GameObject characterMessage;
    [SerializeField]
    private GameObject characterImage;

    private int playerLevelHome;
    private string playerNameHome;
    private float expGaugeHome;
    private int gatyaAmountHome;
    private int expAmountHome;
    private int moneyAmountHome;
    private int imageNumHome;
    private string characterNameHome;
    private string characterMessageHome;

    void Start()
    {
        SetFields();
        DrawHomeUI();
        messageWindow.SetActive(false);
    }

    private void DrawHomeUI()
    {
        playerLevel.GetComponent<Text>().text = playerLevelHome.ToString();
        playerName.GetComponent<Text>().text = playerNameHome;
        playerGauge.GetComponent<Image>().fillAmount = expGaugeHome;
        gatyaText.GetComponent<Text>().text = gatyaAmountHome.ToString();
        expText.GetComponent<Text>().text = expAmountHome.ToString();
        moneyText.GetComponent<Text>().text = moneyAmountHome.ToString();
        characterName.GetComponent<Text>().text = characterNameHome;
        characterMessage.GetComponent<Text>().text = characterMessageHome;

        switch (imageNumHome) {
            case 0:
                characterImage.GetComponent<Image>().color = Color.red;
                break;
            case 1:
                characterImage.GetComponent<Image>().color = Color.blue;
                break;
            case 2:
                characterImage.GetComponent<Image>().color = Color.green;
                break;
            case 3:
                characterImage.GetComponent<Image>().color = Color.yellow;
                break;
            case 4:
                characterImage.GetComponent<Image>().color = Color.magenta;
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }

    private void SetFields()
    {
        playerLevelHome = Hy_Test_Data.playerLevel;
        playerNameHome = Hy_Test_Data.playerName;
        expGaugeHome = Hy_Test_Data.playerGauge;
        gatyaAmountHome = Hy_Test_Data.gatyaAmount;
        expAmountHome = Hy_Test_Data.expAmount;
        moneyAmountHome = Hy_Test_Data.moneyAmount;
        imageNumHome = Hy_Test_Data.imageNum;
        characterNameHome = Hy_Test_Data.characterName;
        characterMessageHome = Hy_Test_Data.characterMessage;
    }

    public void MessageCoroutine()
    {
        StartCoroutine("ShowMessageWindow");
    }

    private IEnumerator ShowMessageWindow()
    {
        messageWindow.SetActive(true);
        switch (imageNumHome)
        {
            case 0:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character1";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Red";
                break;
            case 1:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character2";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Blue";
                break;
            case 2:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character3";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Green";
                break;
            case 3:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character4";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Yellow";
                break;
            case 4:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character5";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Purple";
                break;
            default:
                Debug.Log("Error");
                break;
        }
        yield return new WaitForSeconds(3.0f);
        messageWindow.SetActive(false);
        yield break;
    }
}
