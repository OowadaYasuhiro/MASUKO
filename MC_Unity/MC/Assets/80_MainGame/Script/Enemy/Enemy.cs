using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class Enemy
{
    //体力管理
    DamageModelComponent damageModel;

    //基本情報
    EnemyData enemyData;

    //ステート
    EnemyState enemyState = new EnemyState();

    //スキルイベント
    SkillEvent gameEvent;
    public SkillEvent SetGameEvent {get{ return gameEvent;} set { gameEvent = value;} }

    //イベント管理
    MainGameSkillEvent mainGameSkillEvent;

    public Enemy(EnemyName enemyName,string difficulty)
    {
        enemyData = new EnemyData(enemyName,difficulty);
        damageModel = new DamageModelComponent(enemyData.maxHp,enemyData.physicsDamageResistance,enemyData.zyuGekiResistance,enemyData.zyuRyokuResistance);
    }

    public int CheckHp { get => damageModel.Hp; private set{; } }


    // Start is called before the first frame update
    void Start()
    {
        enemyState.state = Enemystate.Wait;
    }

    //メインゲームの状態を受け取って行動を判断
    public void GetMainState(GameState gs)
    {
        if (gs == GameState.BeforeStart || gs == GameState.End)
        {
            enemyState.state = Enemystate.Wait;
        }
        if (gs == GameState.GameRun)
        {
            enemyState.state = Enemystate.Run;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyState.state)
        {
            case Enemystate.Wait:

                enemyState.CheckState(damageModel);
                break;
            case Enemystate.Run:

                gameEvent();
                enemyState.CheckState(damageModel);
                break;
            case Enemystate.Stan:

                gameEvent();
                enemyState.CheckState(damageModel);
                break;
            case Enemystate.Fight:

                gameEvent();
                enemyState.CheckState(damageModel);
                break;
            case Enemystate.RunAway:

                enemyState.CheckState(damageModel);
                break;
            case Enemystate.Dead:

                enemyState.CheckState(damageModel);
                break;
        }
        gameEvent = new SkillEvent(mainGameSkillEvent.Null);
    }

    public void ChengeEnemyState(Enemystate valeState)
    {
        enemyState.state = valeState;
    }
}
