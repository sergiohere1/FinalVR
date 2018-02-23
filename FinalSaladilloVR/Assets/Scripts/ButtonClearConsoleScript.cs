using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonClearConsoleScript : MonoBehaviour {
	
	public string text;
	public Text ipAdress;

	private void Start()
	{
		GetComponentInChildren<Text>().text = text;
	}

	public void Click()
	{
		ipAdress.text = "";
	}
}
