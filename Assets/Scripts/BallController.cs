using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(ConstantForce))]
public class BallController : MonoBehaviour
{
    public float strength;

    private Rigidbody rb;
    private ConstantForce cForce;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cForce = GetComponent<ConstantForce>();
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -0.45f)
        {
            rb.MovePosition(startPos);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        cForce.force = new Vector3(Input.GetAxis("Horizontal") * strength, -9.81f, Input.GetAxis("Vertical") * strength);
        cForce.force = cForce.force.normalized;
        cForce.force *= 9.81f;
    }
}
