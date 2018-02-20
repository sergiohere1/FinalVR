using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

	public GameObject clickObject;
	

	// Use this for initialization
	void Start () {
		//Recibe un parámetro true o false para activar o no un gameobject
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click()
	{
		clickObject.SetActive(!clickObject.activeSelf);
	}
}
