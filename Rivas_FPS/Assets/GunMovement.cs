using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    [SerializeField]
    float aimRight = 1;

    [SerializeField]
    float aimUp = -1;

    [SerializeField]
    Transform pad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Mouse X");
        float b = Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(0, a * aimRight, 0));
        pad.Rotate(new Vector3(b * aimUp, 0, 0));
    }
}
