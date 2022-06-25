using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{
    public void OnClickShopButton()
    {
        Load_Deta.Nextscenename = "StoreScreenScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
