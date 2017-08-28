using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody myRB;
    public float moveSpeed;

    public int health;
    protected int currentHealth;

    public PlayerController thePlayer;
	// Use this for initialization
	void Start () {
        currentHealth = health;
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
	}

    private void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }
    // Update is called once per frame
    void Update () {
        transform.LookAt(thePlayer.transform.position);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void hurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
