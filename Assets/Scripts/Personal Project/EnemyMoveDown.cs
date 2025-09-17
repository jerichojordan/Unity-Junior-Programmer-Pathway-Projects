using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyMoveDown : MonoBehaviour
{
    private float initialSpeed = 7.0f;
    private float speedAccel = 3.0f;
    private float normalSpeed = 7.0f;
    private float maxSpeed = 20.0f;
    private float zBound = -10.0f;
    public bool isUsingAccel;
    private Vector3 playerPos;
    private Vector3 moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = GameObject.Find("Player").transform.position;
        moveDirection = (playerPos - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
        if (transform.position.z < zBound) Destroy(gameObject);
    }
    void MoveDown()
    {
        //if (playerPos != Vector3.zero)
        //{
            if (isUsingAccel)
            {
                transform.position += moveDirection * initialSpeed * Time.deltaTime;
                if (initialSpeed < maxSpeed) initialSpeed += speedAccel * Time.deltaTime;
                transform.rotation = Quaternion.LookRotation(moveDirection);
            }
            else
            {
                transform.position += moveDirection * normalSpeed * Time.deltaTime;
                transform.rotation = Quaternion.LookRotation(moveDirection);
            }
        //}
    }
}
