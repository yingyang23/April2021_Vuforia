using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMagnifyingGlass : MonoBehaviour
{

    float horizontalInput;
    float verticalInput;
    float minVerticalBound = 0.1f;
    float maxVerticalBound = 1.3f;
    float xRange = 0.9f;
    [SerializeField] float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.z < minVerticalBound)
        {
            ForwardMovementBoundary();
        }
        if(transform.position.z > maxVerticalBound)
        {
            BackwardMovementBoundary();
        }
        if(transform.position.x > xRange)
        {
            LeftBoundary();
        }
        if (transform.position.x < -xRange)
        {
            RightBoundary();
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * horizontalInput * speed);
        transform.Translate(Vector3.back * verticalInput * speed);
    }

    void ForwardMovementBoundary()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, minVerticalBound);
    }

    void BackwardMovementBoundary()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, maxVerticalBound);
    }

    void LeftBoundary()
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    void RightBoundary()
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }
}
