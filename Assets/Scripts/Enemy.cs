using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage(){
		health -= 50;
		if (health<=0){
			Die();
		}
	}

	void Die(){
		Destroy(gameObject);
	}
}
