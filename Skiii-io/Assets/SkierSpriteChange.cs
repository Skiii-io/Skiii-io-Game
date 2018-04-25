using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkierSpriteChange : MonoBehaviour
{

	private SpriteRenderer sprd;

	public Sprite SpriteDown;
	public Sprite SpriteRight;
	public Sprite SpriteLeft;

	void Start()
	{
		sprd = GetComponent<SpriteRenderer>();
	}
	
	void Update()
	{
		if (StartTextDisplay.StartGame)
		{
			if (GameObject.FindGameObjectWithTag("Skier").GetComponent<SkierController>().GoingLeft)
			{
				sprd.sprite = SpriteLeft;
			}

			else if (GameObject.FindGameObjectWithTag("Skier").GetComponent<SkierController>().GoingRight)
			{
				sprd.sprite = SpriteRight;
			}
			else if (GameObject.FindGameObjectWithTag("Skier").GetComponent<SkierController>().GoingLeft == false && GameObject.FindGameObjectWithTag("Skier").GetComponent<SkierController>().GoingRight == false)
			{
				sprd.sprite = SpriteDown;
			}
		}
	}
	
	
	
}
