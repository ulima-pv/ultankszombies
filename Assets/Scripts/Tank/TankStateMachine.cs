using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies.Tank
{
    public class TankStateMachine
    {
        public TankState CurrentState { get; private set; }

        public void Start(TankState initialState)
        {
            CurrentState = initialState;
            CurrentState.OnEnter();
        }

        public void ChangeState(TankState newState)
        {
            CurrentState.OnExit();
            CurrentState = newState;
            CurrentState.OnEnter();
        }
    }
}
