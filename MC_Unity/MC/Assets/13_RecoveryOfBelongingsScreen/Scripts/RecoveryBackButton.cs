using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecoveryBackButton : MonoBehaviour
{
    public void OnClickBuck()
    {
        SceneManager.LoadScene("OrganizationScreenScene");
    }
}
