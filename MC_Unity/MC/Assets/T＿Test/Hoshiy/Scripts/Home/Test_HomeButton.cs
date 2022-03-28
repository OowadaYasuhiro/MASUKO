using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test_HomeButton : MonoBehaviour
{
    public void OnClickFight()
    {
        Debug.Log("fight");
    }

    public void OnClickFormation()
    {
        SceneManager.LoadScene("Hoshiy_TestFormationScene");
    }

    public void OnClickEnhance()
    {
        Debug.Log("enhance");
    }

    public void OnClickGatya()
    {
        Debug.Log("gatya");
    }

    public void OnClickShop()
    {
        Debug.Log("shop");
    }

    public void OnClickMission()
    {
        SceneManager.LoadScene("Hoshiy_TestMissonScene");
    }

    public void OnClickOption()
    {
        Debug.Log("option");
    }

    public void OnClickCharacter()
    {
        this.gameObject.GetComponent<Test_HomeMain>().MessageCoroutine();
    }
}
