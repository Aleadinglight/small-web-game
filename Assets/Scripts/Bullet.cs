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

	void OnTriggerEnter2D(Collider2D collider) {
		print(collider.tag);
		if (collider.tag=="Enemy"){	
			Enemy enemy = collider.GetComponent<Enemy>();
			if (enemy!=null){
				enemy.TakeDamage();
			}
		}
		if (collider.tag!="Player")
			Destroy(gameObject);
	}
}
