using System;

[Serializable]
public class BuffData
{
    public enum BuffType
    {
        Healing,
        AddAttackSpeed,
    }

    public BuffType m_buffType;
    public int m_ratio;
    public TimerData m_timerData;
}
