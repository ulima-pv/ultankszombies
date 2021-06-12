using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies.Zombies
{
    public class ZombieStateMachine
    {
        public ZombieState CurrentState { get; private set; }

        public void Start(ZombieState initialState)
        {
            CurrentState = initialState;
            CurrentState.OnEnter();
        }

        public void ChangeState(ZombieState newState)
        {
            CurrentState.OnExit();
            CurrentState = newState;
            CurrentState.OnEnter();
        }
    }
}
