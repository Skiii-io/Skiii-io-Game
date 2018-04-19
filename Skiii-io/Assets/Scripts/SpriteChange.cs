using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{

	public Sprite Sprite1;
	public Sprite Sprite2;

	public float Sprite1Time;
	public float Sprite2Time;

	private SpriteRenderer sprd;

	void Start()
	{
		sprd = GetComponent<SpriteRenderer>();
		Invoke("ChangetoSprite2", Sprite1Time);
	}

	void ChangetoSprite1()
	{
		sprd.sprite = Sprite1;
		Invoke("ChangetoSprite2", Sprite1Time);
	}

	void ChangetoSprite2()
	{
		sprd.sprite = Sprite2;
		Invoke("ChangetoSprite1", Sprite2Time);
	}
}
