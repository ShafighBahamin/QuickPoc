using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
		Vector3 vec = Camera.main.ScreenToWorldPoint((Vector2)Input.mousePosition);
        vec.z = 0;
        this.transform.position = vec;

    }
}
