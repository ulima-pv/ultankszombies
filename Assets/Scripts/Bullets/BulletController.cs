using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies.Bullets
{
    [RequireComponent(typeof(Rigidbody))]
    public class BulletController : MonoBehaviour
    {
        public float force;

        void Start()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }

    }
}
