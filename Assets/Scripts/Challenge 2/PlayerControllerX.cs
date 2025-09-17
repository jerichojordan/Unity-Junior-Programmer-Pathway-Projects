using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Challenge2
{
    public class PlayerControllerX : MonoBehaviour
    {
        public GameObject dogPrefab;
        private float currentTime;
        private float spawnDelay = 1.0f;

        // Update is called once per frame
        void Update()
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > currentTime + spawnDelay)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                currentTime = Time.time;
            }
        }
    }

}
