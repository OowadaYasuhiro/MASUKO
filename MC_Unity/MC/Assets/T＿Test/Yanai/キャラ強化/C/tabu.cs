using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabu : MonoBehaviour
{
    [SerializeField] GameObject Level;
    [SerializeField] GameObject Skill;
    [SerializeField] GameObject Gentotu;
    [SerializeField] GameObject Zyuryoku;

    void Start()
    {
        Level.gameObject.SetActive(true);
        Skill.gameObject.SetActive(false);
        Gentotu.gameObject.SetActive(false);
        Zyuryoku.gameObject.SetActive(false);
    }
    public void level() {
        Level.gameObject.SetActive(true);
        Skill.gameObject.SetActive(false);
        Gentotu.gameObject.SetActive(false);
        Zyuryoku.gameObject.SetActive(false);
    }
    public void skill() {
        Level.gameObject.SetActive(false);
        Skill.gameObject.SetActive(true);
        Gentotu.gameObject.SetActive(false);
        Zyuryoku.gameObject.SetActive(false);
    }
    public void gentotu() {
        Level.gameObject.SetActive(false);
        Skill.gameObject.SetActive(false);
        Gentotu.gameObject.SetActive(true);
        Zyuryoku.gameObject.SetActive(false);
    }
    public void zyuryoku() {
        Level.gameObject.SetActive(false);
        Skill.gameObject.SetActive(false);
        Gentotu.gameObject.SetActive(false);
        Zyuryoku.gameObject.SetActive(true);
    }
}
