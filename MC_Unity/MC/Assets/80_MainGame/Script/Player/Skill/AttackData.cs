using System;
using static Constant;

[Serializable]
public class AttackData
{
    public bool m_continuous;
    public DamageType m_damageType;
    public double m_damageMagnification;

    public TimerData m_timerData;
}
