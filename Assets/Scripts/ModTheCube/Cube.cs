// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 newPos;
    public Vector3 newScale;
    public float rotationSpeed = 10.0f;
    public float acceleration = 0.1f;
    private Material material;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        material = Renderer.material;
        material.color = new Color(Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f));
    }

    void Update()
    {
        if (rotationSpeed < 7) transform.Rotate(rotationSpeed, 0.0f, 0.0f);
        else if (rotationSpeed > 7 && rotationSpeed < 12) transform.Rotate(0.0f, rotationSpeed, 0.0f);
        else if (rotationSpeed > 12 && rotationSpeed < 17) transform.Rotate(0.0f, 0.0f,rotationSpeed); 
        else rotationSpeed = 2.0f;
        rotationSpeed += acceleration * Time.deltaTime;
    }

}
