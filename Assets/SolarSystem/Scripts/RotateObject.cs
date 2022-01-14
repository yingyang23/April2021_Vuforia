using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public float speedX;
    public float speedY;
    public float speedZ;
    public string name;
    public bool shouldSpin = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if(shouldSpin == true)
        {
            //transform.Rotate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
            transform.Rotate((Vector3.right * speedX) * (Time.deltaTime), Space.Self);
            transform.Rotate((Vector3.up * speedY) * (Time.deltaTime), Space.Self);
            transform.Rotate((Vector3.forward * speedZ) * (Time.deltaTime), Space.Self);
        }
    }
}
