using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    [SerializeField] private ChaseState _chaseState;
    [SerializeField] private bool canSeeEnemy;
    public override State RunCurrentState()
    {
        //canSeeEnemy = IsThereEnemyNearby();
        if (canSeeEnemy)
        {
            return _chaseState;
        }
        return this;
    }

    private bool IsThereEnemyNearby()
    {
        
        //TODO: get list of enemies and locate the closest in a distance
        return false;
    }
}
