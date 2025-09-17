using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //
    [SerializeField]private float speed = 20.0f;
    [SerializeField]private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical"); 
        //Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
