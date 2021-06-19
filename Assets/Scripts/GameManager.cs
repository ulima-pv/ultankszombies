using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULTanksZombies
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        public static GameManager Instance { get { return instance; } }

        public GameObject[] zombies;
        public float spawnZombieTime = 3f;

        private float timerToSpawnZombie = 0f;


        public Transform tank;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        private void Update()
        {
            if( timerToSpawnZombie > spawnZombieTime)
            {
                SpawnZombie();
                timerToSpawnZombie = 0f;
            }
            timerToSpawnZombie += Time.deltaTime;
        }

        private void SpawnZombie()
        {
            int posZombies = Random.Range(0, zombies.Length);
            Vector3 spawnPosition = new Vector3(
                Random.Range(tank.position.x - 50f , tank.position.x + 50),
                0.5f,
                Random.Range(tank.position.z - 50f, tank.position.z + 50)
            );
            Instantiate(zombies[posZombies], spawnPosition, Quaternion.identity);
        }
    }
}
