using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFlecha : MonoBehaviour
{
	private Transform position;
	public float speed = 1f;
	
	// Use this for initialization
	void Start ()
	{
		position = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		position.Translate(Vector3.down * speed * Time.fixedDeltaTime);
	}
}
