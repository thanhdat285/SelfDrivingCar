using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speedForce = 10f;
    float posX = 3.046f;
    float posY = -3.116f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Accelerate"))
        {
            //GetComponent<Rigidbody2D>().AddForce(transform.up * speedForce);

            //var collider = GetComponent<PrimitiveType.Sphere>();
            //Debug.Log(collider.name);
        }
    }
}
