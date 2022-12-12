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
    public AttackData[] m_attackData;
    public bool m_addBuff;
    public BuffData[] m_buffDatas;
    public bool m_addDebuff;
    public BuffData[] m_debuffDatas;


    public enum SkillTargetingType
    {
        Attack,
        Support
    }

}

[Serializable]
public class AttackData
{
    public bool m_continuous;
    public DamageType m_damageType;
    public double m_damageMagnification;

    public TimerData m_timerData;
}

[Serializable]
public class BuffData
{
    public enum DebuffType
    {
        Speed,
        Defense,
        Attack
    }

    public DebuffType m_debuffType;
    public int m_ratio;
    public TimerData m_timerData;
}

[Serializable]
public class TimerData
{
    public int m_lifeFrame;
    public int m_doTick;
}
