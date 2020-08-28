using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(ConstantForce))]
public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private ConstantForce cForce;

    private float forceScalar;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cForce = GetComponent<ConstantForce>();
        forceScalar = cForce.force.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
