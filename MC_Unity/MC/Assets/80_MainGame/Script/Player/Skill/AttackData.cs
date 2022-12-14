using System;
using static Constant;

[Serializable]
public class AttackData
{
    public enum DamageResource
    {
        BaseAttackPower,
        PhysicsDamageResistance
    }
    public DamageResource m_damageResource;
    public DamageType m_damageType;
    public double m_damageMagnification;
    public TimerData m_timerData;
}
