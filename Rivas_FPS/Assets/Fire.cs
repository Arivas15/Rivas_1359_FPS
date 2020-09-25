using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float bulletSpd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(States.magazine.ammo > 0)
            {
                Vector3 bulletDirection = transform.forward * bulletSpd;
                GameObject b = Instantiate(bullet, transform.position, transform.rotation);
                b.GetComponent<Rigidbody>().velocity = bulletDirection;
                States.magazine.ammo -= 1;
            }
        }
    }
}
