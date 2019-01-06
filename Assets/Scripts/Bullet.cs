using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 0.8f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent <Rigidbody2D> ();
		rb2d.velocity = transform.right * speed;
	}

	void OnTringgerEnter2D(Collider2D collision){
		if (collision.gameObject.tag=="Enemy"){
			Enemy enemy = collision.GetComponent<Enemy>();
			if (enemy!=null){
				enemy.TakeDamage;
			}
		}
		Destroy(gameObject);
	}
}
