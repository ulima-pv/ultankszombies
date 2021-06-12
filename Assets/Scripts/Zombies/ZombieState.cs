using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies.Zombies
{
    public abstract class ZombieState
    {
        protected ZombieController controller;
        protected ZombieStateMachine fsm;

        public ZombieState(ZombieController controller, ZombieStateMachine fsm)
        {
            this.controller = controller;
            this.fsm = fsm;
        }

        public virtual void OnEnter() { }
        public virtual void OnExit() { }
        public virtual void OnHandleInput() { }
        public virtual void OnLogicUpdate() { }
        public virtual void OnPhysicsUpdate() { }
    }
}
