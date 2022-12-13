using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static Constant;

[CreateAssetMenu(fileName ="PlayerSkillData", menuName ="ScriptableObjects/PlayerSkillData", order =1)]
public class PlayerSkillData : ScriptableObject
{
    public bool m_originalAttackRange;
    public Vector2[] m_attackRange;
    public SkillTargetingType m_type;
    public bool m_stan;
    public TimerData m_stanTimeData;
    public AttackData[] m_attackData;
    public BuffData[] m_buffDatas;
    public BuffData[] m_debuffDatas;
    public GameObject m_summonObject;

    public enum SkillTargetingType
    {
        Attack,
        Support
    }
}
