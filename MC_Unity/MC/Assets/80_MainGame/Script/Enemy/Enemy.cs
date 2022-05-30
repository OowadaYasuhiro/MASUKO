using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
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
=======
using UnityEngine.UIElements;

public class Enemy : MainGameCharactorModel
>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350
{
    //戦闘時間
    const float maxFightTime = 10f;
    float fightTime;


<<<<<<< HEAD
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
=======
    public Enemy(string name)
>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350
    {
        this.name = name;
    }

<<<<<<< HEAD
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
=======
    private void Start()
    {
        charactorState = CharactorState.Standby;
        charactorAnimState = CharactorAnimState.Wait;
>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharactorState.Run:

                break;
        }
<<<<<<< HEAD
=======
        
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }

    //計算
    public void UpDate()
    {
<<<<<<< HEAD
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
=======
        //スキルの反映とリセット
        skillEvent();
        ReMoveAllEvents();
>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350
    }

    //結果
    public void LateUpDate()
    {
<<<<<<< HEAD
        enemyState.state = valeState;
<<<<<<< HEAD
=======
        
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
=======

>>>>>>> 93495dbe741ce2cc33748768ef72a24be66db350
    }
}
