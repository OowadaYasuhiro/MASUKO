using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainGameCharacterState;
using static Constant;

public class PlayerSkill : MonoBehaviour
{
    public bool m_skillActivating;
    public int m_skillCoolDown;
    public int m_skillCoolTime;
    public bool m_skillEnabled;
    public bool m_lateSkillEnabled;
    public int m_skillStack;
    int m_maxSkillStack;

    PlayerSkillData m_playerSkillData;

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

    void Skill()
    {
        MainGameCharacterModel[] target;
        if (m_playerSkillData.m_originalAttackRange == true)
        {
            if (m_playerSkillData.m_type == PlayerSkillData.SkillTargetingType.Attack)
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_playerSkillData.m_attackRange, false, true, false);
            }
            else
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_playerSkillData.m_attackRange, true, false, false);
            }
        }
        else
        {
            if (m_playerSkillData.m_type == PlayerSkillData.SkillTargetingType.Attack)
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_player.attackRange, false, true, false);
            }
            else
            {
                target = m_mainGame.SearchCharacter(m_player.position, m_player.attackRange, true, false, false);
            }
        }
        
        
        foreach (MainGameCharacterModel targetCharacter in target)
        {
            if (m_playerSkillData.m_stan == true)
            {
                StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, m_playerSkillData.m_stanTimeData, Stan));
                void Stan()
                {
                    targetCharacter.charactorState = CharacterState.Stan;
                }
            }
            if (m_playerSkillData.m_attackData.Length > 0)
            {
                for (int i = 0; i < m_playerSkillData.m_attackData.Length; i++)
                {
                    AttackSKill(targetCharacter, i);
                }
            }
            
            void Healing()
            {

            }
            void AddAttackSpeed()
            {

            }
            void Summon()
            {

            }
            void Buff()
            {

            }
            void DeBuff()
            {

            }
            void KnockBack()
            {

            }
        }
    }

    void AttackSKill(MainGameCharacterModel targetCharacter, int loopNumber)
    {
        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(targetCharacter, m_playerSkillData.m_attackData[loopNumber].m_timerData, PlayerSkillAttack));
        void PlayerSkillAttack()
        {
            Damage damage = new Damage(m_playerSkillData.m_attackData[loopNumber].m_damageType, (int)(m_player.baseAttackPower * m_playerSkillData.m_attackData[loopNumber].m_damageMagnification));
            targetCharacter.AddDamage(damage);
        }
    }
}
