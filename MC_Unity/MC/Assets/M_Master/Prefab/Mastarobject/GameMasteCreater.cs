using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasteCreater : MonoBehaviour
{
    private static bool Loadid { get; set; }

    [SerializeField]
    GameObject MasterPrefab;

    private void Awake()
    {
        if (Loadid) return;

        Loadid = true;

        GameObject go = Instantiate(MasterPrefab);
        DontDestroyOnLoad(go);
    }
}
