using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using static Constant;

public class Enemy
=======

public class Enemy : MonoBehaviour
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
using static Constant;

public class Enemy
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
{
    //体力管理
    DamageModelComponent damageModel;

    //基本情報
    EnemyData enemyData;

<<<<<<< HEAD
<<<<<<< HEAD
    //ステート
    EnemyState enemyState = new EnemyState();

    //スキルイベント
    SkillEvent gameEvent;
    public SkillEvent SetGameEvent {get{ return gameEvent;} set { gameEvent = value;} }

    //イベント管理
    MainGameSkillEvent mainGameSkillEvent;

    public Enemy(EnemyName enemyName,string difficulty)
=======

    public Enemy(EnemyData.EnemyName enemyName,string difficulty)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
    //ステート
    EnemyState enemyState = new EnemyState();

    //スキルイベント
    SkillEvent gameEvent;
    public SkillEvent SetGameEvent {get{ return gameEvent;} set { gameEvent = value;} }

    //イベント管理
    MainGameSkillEvent mainGameSkillEvent;

    public Enemy(EnemyName enemyName,string difficulty)
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    {
        enemyData = new EnemyData(enemyName,difficulty);
        damageModel = new DamageModelComponent(enemyData.maxHp,enemyData.physicsDamageResistance,enemyData.zyuGekiResistance,enemyData.zyuRyokuResistance);
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public int CheckHp { get => damageModel.Hp; private set{; } }

=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
    public int CheckHp { get => damageModel.Hp; private set{; } }

>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
=======
        
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
=======
        
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }
}
