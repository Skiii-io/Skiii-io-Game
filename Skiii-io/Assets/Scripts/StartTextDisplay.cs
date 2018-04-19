using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class StartTextDisplay : MonoBehaviour
{

	public static bool StartTrue;
	public static bool StartGame;
	public GameObject InvisWall;
	public Text StartText;

	void Start()
	{
		Invoke("CheckForTrue", 12f);
	}

	private void Three()
	{
		StartText.text = "3";
		Invoke("Wipe", 0.99f);
		Invoke("Two", 1f);
	}

	private void Two()
	{
		StartText.text = "2";
		Invoke("Wipe", 0.99f);
		Invoke("One", 1f);
	}

	private void One()
	{
		StartText.text = "1";
		Invoke("Wipe", 0.99f);
		Invoke("Skiii", 1f);
	}

	private void Skiii()
	{
		StartText.text = "Skiii!";
		Invoke("Wipe", 1f);
		Destroy(InvisWall);
		StartGame = true;
	}

	private void Wipe()
	{
		StartText.text = "";
	}
	
	private void CheckForTrue()
	{
		if (StartTrue)
		{
			Invoke("Three", 0f);
		}
	}
}
