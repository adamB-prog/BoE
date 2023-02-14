using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    [SerializeField] private IdleState _idleState;
    [SerializeField] private bool haveBeenShot;
    [SerializeField] private bool enemyDestroyed;

    public override State RunCurrentState()
    {
        if (!haveBeenShot && !enemyDestroyed) return this;
        haveBeenShot = false;
        enemyDestroyed = false;
        return _idleState;

    }

    public void HaveBeenShot()
    {
        haveBeenShot = true;
    }

    public void EnemyDestroyed()
    {
        enemyDestroyed = true;
    }
}