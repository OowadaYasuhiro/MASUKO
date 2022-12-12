using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainGameCharacterState;

public class PlayerSkill
{
    public bool m_skillActivating;
    public int m_skillCoolDown;
    public int m_skillCoolTime;
    public bool m_skillEnabled;
    public bool m_lateSkillEnabled;
    public int m_skillStack;
    int m_maxSkillStack;

    int m_time;
    int m_doTick;

    public SkillEvent m_skillEvent;

    public MainGame m_mainGame;
    public Player m_player;

    public void SkillCoolTimeCounter()
    {
        if (m_skillCoolTime > 0)
        {
            m_skillCoolTime--;
            if (m_skillCoolTime == 0)
            {
                m_skillEnabled = true;
                m_skillStack++;
                if (m_skillStack < m_maxSkillStack)
                {
                    m_skillCoolTime = m_skillCoolDown;
                }
            }
        }
    }

    void Skill(Vector2[] attackRange, bool attackTaype, bool stan, bool attack, double damageMagnification)
    {
        MainGameCharacterModel[] target;
        if (attackTaype == true)
        {
            target = m_mainGame.SearchCharacter(m_player.position, attackRange, false, true, false);
        }
        else
        {
            target = m_mainGame.SearchCharacter(m_player.position, attackRange, true, false, false);
        }
        
        foreach (MainGameCharacterModel targetCharacter in target)
        {
            if (stan == true)
            {
                targetCharacter.charactorState = CharacterState.Stan;
            }
            if (attack == true)
            {
                targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(m_player.baseAttackPower * damageMagnification)));
            }
        }
    }

    void Stan()
    {
        //呼び出し時のターゲットの中身が正しいか
        //foreachでいいのか
        //dotickでの参照先は正しいか
    }
}
