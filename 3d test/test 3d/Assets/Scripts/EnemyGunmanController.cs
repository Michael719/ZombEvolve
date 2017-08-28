using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunmanController : EnemyController {

    public GunController theGun;
    private Rigidbody gunmanRB;

    // Use this for initialization
    void Start () {
        currentHealth = health;
        gunmanRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        gunmanRB.velocity = (transform.forward * moveSpeed);
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(thePlayer.transform.position);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        theGun.isFiring = true;
    }


}
