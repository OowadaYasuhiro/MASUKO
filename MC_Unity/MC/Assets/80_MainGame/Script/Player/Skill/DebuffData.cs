using System;

[Serializable]
public class DebuffData
{
    public enum DebuffType
    {
        Speed,
        Defense,
        Attack,
    }

    public DebuffType m_debuffType;

}
