using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : Constant
{
    enum State
    {
        Wait,
        Run,
        Fight,
        RunAway,
        Dead
    } 

    State state;


}
