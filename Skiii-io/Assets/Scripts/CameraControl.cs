using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    public GameObject player;

    private Vector3 offset;
	
    void Start ()
    {
        Invoke("calculateOffset", 14f);
    }
	
    void LateUpdate ()
    {
        if (StartTextDisplay.StartGame)
        {
            transform.position = player.transform.position + offset;
        }     
    }

    void calculateOffset()
    {
        offset = transform.position - player.transform.position;
    }



}
