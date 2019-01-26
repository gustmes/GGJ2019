using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	public float speed;
	private Rigidbody2D rigidBody;
	private Vector2 moveVelocity;
	// Use this for initialization
	void Start () {

		rigidBody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		moveVelocity = moveInput.normalized * speed;
		
	}

	void FixedUpdate(){
		rigidBody.MovePosition(rigidBody.position + moveVelocity * Time.fixedDeltaTime);
	}
}
