using UnityEngine;
namespace PersonalProject
{

    public class FollowPlayer : MonoBehaviour
    {
        private GameObject playerObj;
        private Vector3 offset = new Vector3(0, 10, -5);
        private float smoothSpeed = 0.125f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerObj = GameObject.Find("Player");
        }

        // Update is called once per frame
        void LateUpdate()
        {
            Vector3 desiredPos = playerObj.transform.position + offset;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            transform.position = smoothedPos;
            //transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y + offset.y, playerObj.transform.position.z + offset.z);
        }
    }
}
