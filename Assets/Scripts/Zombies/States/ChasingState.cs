using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ULTanksZombies.Zombies
{
    public class ChasingState : ZombieState
    {
        private Transform tank;
        private float speed;
        private float rotationSpeed;
        private Rigidbody rb;
        private NavMeshAgent navMeshAgent;

        public ChasingState(ZombieController controller, ZombieStateMachine fsm) : base(controller, fsm)
        {
            tank = controller.tank;
            speed = controller.settings.speed;
            rotationSpeed = controller.settings.rotationSpeed;
            rb = controller.GetComponent<Rigidbody>();
            navMeshAgent = controller.GetComponent<NavMeshAgent>();
        }

        public override void OnPhysicsUpdate()
        {
            base.OnPhysicsUpdate();

            navMeshAgent.SetDestination(tank.position);

            /*Vector3 newDirection = 
                (controller.tank.position - controller.transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(newDirection);

            controller.transform.rotation = Quaternion.Slerp(
                controller.transform.rotation,
                rotation,
                rotationSpeed * Time.fixedDeltaTime
            ) ;

            controller.transform.position = Vector3.MoveTowards(
                controller.transform.position,
                tank.position,
                speed * Time.fixedDeltaTime
            ) ;*/

        }
    }
}
