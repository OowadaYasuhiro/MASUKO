using System;

[Serializable]
public class BuffData
{
    public enum DebuffType
    {
        Speed,
        Defense,
        Attack,
        Healing,
        AddAttackSpeed,
    }

    public DebuffType m_debuffType;
    public int m_ratio;
    public TimerData m_timerData;
}
