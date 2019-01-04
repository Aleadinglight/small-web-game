﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float upForce = 100f;
	public float leftForce = -50f;
	public float rightForce = 50f;
	
	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent <Rigidbody2D> ();
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (isDead == false){
			if (Input.GetKeyDown("up")){
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce));
				anim.SetTrigger("Jump");
			}
			if (Input.GetKeyDown("left")){
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(leftForce, 0));
				anim.SetTrigger("Run");
			}
			if (Input.GetKeyDown("right")){
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(rightForce, 0));
				anim.SetTrigger("Run");
			}
		}
	}
}
