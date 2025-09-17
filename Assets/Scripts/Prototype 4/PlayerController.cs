using System.Collections;
using UnityEngine;
namespace Prototype4
{

    public class PlayerController : MonoBehaviour
    {
        private Rigidbody playerRb;
        private GameObject focalPoint;
        public bool hasPowerUp;
        public float speed = 5.0f;
        private float powerupStrength = 15.0f;
        public GameObject powerupIndicator;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerRb = GetComponent<Rigidbody>();
            focalPoint = GameObject.Find("Focal Point");
        }

        // Update is called once per frame
        void Update()
        {
            float verticalInput = Input.GetAxis("Vertical");
            playerRb.AddForce(focalPoint.transform.forward * speed * verticalInput);
            powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Powerup"))
            {
                hasPowerUp = true;
                powerupIndicator.SetActive(true);
                Destroy(other.gameObject);
                StartCoroutine(PowerupCountdownRoutine());
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
            {
                Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
                Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
                Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerUp);
                enemyRigidbody.AddForce(awayFromPlayer.normalized * powerupStrength, ForceMode.Impulse);
            }
        }
        IEnumerator PowerupCountdownRoutine()
        {
            yield return new WaitForSeconds(7);
            hasPowerUp = false;
            powerupIndicator.SetActive(false);
        }
    }
}
