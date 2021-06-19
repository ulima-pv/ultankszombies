using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies.Cameras
{
    public class MinimapCameraController : MonoBehaviour
    {
        public Transform tank;
        private void LateUpdate()
        {
            Vector3 newPosition = new Vector3(
                tank.position.x,
                transform.position.y,
                tank.position.z
            );
            transform.position = newPosition;
        }
    }
}
