using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies.Zombies
{
    public class ZombieController : MonoBehaviour
    {
        public Transform tank;
        public SettingsComponent settings;

        private ZombieStateMachine fsm;
        private ChasingState chasingState;
        

        private void Start()
        {
            fsm = new ZombieStateMachine();
            chasingState = new ChasingState(this, fsm);

            fsm.Start(chasingState);
        }

        private void Update()
        {
            fsm.CurrentState.OnHandleInput();
            fsm.CurrentState.OnLogicUpdate();
        }

        private void FixedUpdate()
        {
            fsm.CurrentState.OnPhysicsUpdate();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                Destroy(gameObject);
            }
        }
    }
}
