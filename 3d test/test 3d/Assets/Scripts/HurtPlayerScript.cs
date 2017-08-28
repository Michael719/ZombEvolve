using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerScript : MonoBehaviour {

    public int damageToGive;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().hurtPlayer(damageToGive);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
