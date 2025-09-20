using UnityEngine;

public class EnemyFollowX : MonoBehaviour
{
    private float speed = 6.0f;
    private float xBound = 15.0f;
    private GameObject playerObj;
    private Animator enemyAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObj = GameObject.Find("Player");
        enemyAnimator = GetComponentInChildren<Animator>();
        enemyAnimator.SetFloat("Speed_f", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayerX();
        RestrictEnemyMoveX();
    }
    void FollowPlayerX()
    {
        Vector3 playerPos = new Vector3(playerObj.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }
    void RestrictEnemyMoveX()
    {
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
    }
}
