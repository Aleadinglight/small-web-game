using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float upForce = 200f;
	public float leftForce = 200f;
	public float rightForce = 200f;
	
	private bool isDead = false;
	private Rigidbody2d rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent <Rigidbody2d> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false){
			if (Input.GetKey("up")){
				rb2d..velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce));
			}
			if (Input.GetKey("left")){
				rb2d..velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, leftForce));
			}
			if (Input.GetKey("right")){
				rb2d..velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, rightForce));
			}
		}
	}
}
