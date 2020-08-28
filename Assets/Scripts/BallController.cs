using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(ConstantForce))]
public class BallController : MonoBehaviour
{
    public float strength;

    private Rigidbody rb;
    private ConstantForce cForce;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cForce = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void Update()
    {
        cForce.force = new Vector3(Input.GetAxis("Horizontal") * strength, -9.81f, Input.GetAxis("Vertical") * strength);
        cForce.force = cForce.force.normalized;
        cForce.force *= 9.81f;
    }
}
