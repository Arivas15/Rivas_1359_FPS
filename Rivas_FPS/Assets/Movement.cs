using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 1;

    [SerializeField]
    Transform cam;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();

        Vector3 moveDirection = (camForward * v * moveSpeed) + (camRight * h * moveSpeed);

        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        if(Input.GetButtonDown("Jump"))
        {
            Ray r = new Ray(transform.position, Vector3.down);

            Debug.DrawLine(r.origin, r.origin + (Vector3.down * 1));

            RaycastHit hit;
            if (Physics.Raycast(r, out hit, 2))
            {
                if (hit.transform != null)
                {
                    Jump();
                }
            }
        }
    }
    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
    }
}
