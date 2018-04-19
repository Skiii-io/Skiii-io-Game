using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCameraShift : MonoBehaviour
{

	private bool cameraMoving;
	
	void Start()
	{
		Invoke("MoveCamera", 2f);
		Invoke("FreezeCamera", 11f);
	}

	void Update()
	{
		if (cameraMoving)
		{
			transform.Translate(Vector3.down * Time.deltaTime);
		}
	}

	private void MoveCamera()
	{
		cameraMoving = true;
	}

	private void FreezeCamera()
	{
		cameraMoving = false;
		StartTextDisplay.StartTrue = true;
	}
	
}
