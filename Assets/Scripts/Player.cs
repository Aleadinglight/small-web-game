using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float upForce = 100f;
	public float leftForce = -50f;
	public float rightForce = 50f;
	
	private bool isDead = false;
	private bool facingRight = true;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent <Rigidbody2D> ();
		anim = GetComponent <Animator> ();
	}
	

	void OnCollisionEnter2D(Collision2D collision){
		string nextDoorName = "";

		if (collision.gameObject.name=="DeadWall"){
			isDead = true;
			print("dead");
		}

		if(collision.gameObject.name=="BotLeftDoor"){
			nextDoorName = "TopRightDoor";
		}

		if(collision.gameObject.name=="BotRightDoor"){
			nextDoorName = "TopLeftDoor";
		}
		if (nextDoorName!=""){
			Vector3 newPosition = GameObject.Find(nextDoorName).transform.position;
			this.rb2d.position = new Vector2(newPosition.x, newPosition.y);
		}
	}

	// Update is called once per frame
	void Update () {
	
		if (isDead == false){
			if (Input.GetKeyDown("up")){
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce));
			}
			if (Input.GetKeyDown("left")){
				Move("Left");
			}
			if (Input.GetKeyDown("right")){
				Move("Right");
			}
		}

		
	}

	void Flip(){
		transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
		facingRight = !facingRight;
	}

	void Move(string direction){
		float moveForce;
		if (direction=="Left"){
			moveForce = leftForce;
			if(facingRight){
				Flip();
			}
		}
		else
		{
			moveForce = rightForce;
			if(!facingRight){
				Flip();
			}
		}
		anim.SetTrigger("Run");
		rb2d.velocity = Vector2.zero;
		rb2d.AddRelativeForce(new Vector2(moveForce, 0));
		
	}
}
