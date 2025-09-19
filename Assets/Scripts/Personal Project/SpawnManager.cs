using UnityEngine;
namespace PersonalProject
{

    public class SpawnManager : MonoBehaviour
    {
        public GameObject[] enemyMoveDownPrefabs;
        public GameObject enemyMoveXPrefab;
        private GameObject playerObj;
        private float spawnDistanceZ = 15.0f;
        private float spawnInterval = 3.0f;
        private float xBound = 15.0f;
        private float[] spawnPosZ = new float[] { 7, 15, 25, 27, 38, 52, 67, 69, 75, 88, 90, 92, 104, 115, 117, 121, 123, 125, 127, 129 };
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerObj = GameObject.Find("Player");
            for (int i = 0; i < spawnPosZ.Length; i++)
            {
                Instantiate(enemyMoveXPrefab, new Vector3(playerObj.transform.position.x, playerObj.transform.position.y, playerObj.transform.position.z + spawnPosZ[i]), enemyMoveXPrefab.transform.rotation);
            }
        }

        public void InvokeSpawnEnemy()
        {
            InvokeRepeating("SpawnEnemy", 0, spawnInterval);
        }
        void SpawnEnemy()
        {
            int randomIndex = Random.Range(0, enemyMoveDownPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-xBound, xBound), playerObj.transform.position.y, playerObj.transform.position.z + spawnDistanceZ);
            Instantiate(enemyMoveDownPrefabs[randomIndex], spawnPos, enemyMoveDownPrefabs[randomIndex].transform.rotation);
        }
        public void StopSpawnEnemy()
        {
            CancelInvoke("SpawnEnemy");
        }
    }
}
