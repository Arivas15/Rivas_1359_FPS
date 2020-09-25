using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(States.magazine.ammo < 10)
        {
            States.magazine.ammo += 1;
            if(States.magazine.ammo == 10)
            {
                Destroy(gameObject);
            }
        }
    }
}
