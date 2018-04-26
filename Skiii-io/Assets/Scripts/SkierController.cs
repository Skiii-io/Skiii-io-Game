using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class SkierController : MonoBehaviour
{


	public float speed;
	private Rigidbody2D rb2d;

	private float downSpeed;
	private float currentGravity;

	public bool GoingLeft;
	public bool GoingRight;

	void Start()
	{
		downSpeed = rb2d.velocity.y;
		currentGravity = rb2d.gravityScale;
	}
	
	void FixedUpdate()
	{
		rb2d = GetComponent<Rigidbody2D>();
		if (StartTextDisplay.StartGame)
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				MoveLeft();
			}
			else if (Input.GetKeyDown(KeyCode.D))
			{
				MoveRight();
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				MoveDown();
			}
		}
	}

	void MoveLeft()
	{
		Vector3 LeftMovement = new Vector3(-20f, downSpeed, 0f);

		rb2d.AddForce(LeftMovement * speed);

		rb2d.gravityScale = currentGravity;
		
		GoingLeft = true;
		GoingRight = false;
	}

	void MoveRight()
	{
		Vector3 RightMovement = new Vector3(20f, downSpeed, 0f);

		rb2d.AddForce(RightMovement * speed);
		
		rb2d.gravityScale = currentGravity;

		GoingRight = true;
		GoingLeft = false;
	}

	void MoveDown()
	{
		Vector3 DownMovement = new Vector3(0f, 0f, 0f);

		GoingLeft = false;
		GoingRight = false;
		
		
	}
}
