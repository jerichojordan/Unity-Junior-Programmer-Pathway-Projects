using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
