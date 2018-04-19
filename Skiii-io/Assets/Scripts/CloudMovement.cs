using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

	public GameObject Cloud;
	private Rigidbody2D rb2d;
	public string CloudDirection;
	public float CloudSpeed;
	
	void Update()
	{
		rb2d = GetComponent<Rigidbody2D>();
		if (CloudDirection == "right")
		{
			rb2d.transform.Translate(Vector3.right * (Time.deltaTime * CloudSpeed));
		}
		else if (CloudDirection == "left")
		{
			rb2d.transform.Translate(Vector3.left * (Time.deltaTime * CloudSpeed));
		}	
	}
}
