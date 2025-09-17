using UnityEngine;
using UnityEngine.EventSystems;
namespace PersonalProject
{

    public class PlayerController : MonoBehaviour
    {
        private float speed = 10.0f;
        private float horizontalInput;
        private float verticalInput;
        private float xBound = 15.0f;
        private float zBound = -5.0f;
        private Animator playerAnim;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerAnim = GetComponentInChildren<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            MovePlayer();
            ConstrainPlayerMovement();
        }
        void MovePlayer()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            Vector3 moveDir = new Vector3(horizontalInput, 0f, verticalInput).normalized;
            if (moveDir.magnitude > 0.01f)
            {
                transform.rotation = Quaternion.LookRotation(moveDir, Vector3.up);
                transform.Translate(moveDir * Time.deltaTime * speed, Space.World);
                playerAnim.SetFloat("Speed_f", 0.6f);
            }
            else playerAnim.SetFloat("Speed_f", 0f);
        }
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        void ConstrainPlayerMovement()
        {
            if (transform.position.x > xBound)
            {
                transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
            }
            if (transform.position.x < -xBound)
            {
                transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
            }
            if (transform.position.z < zBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Powerup"))
            {
                Debug.Log("Collected powerup");
                Destroy(other.gameObject);
            }
            else if (other.CompareTag("Enemy"))
            {
                Debug.Log("Game Over");
            }
            else if (other.CompareTag("Finish"))
            {
                Debug.Log("Finish");
            }
        }
    }
}
