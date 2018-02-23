using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTecla : MonoBehaviour
{
	public string textoResultante = "";
	public string tecla;
	public Text textoResultado;
	private bool flechaHaEntrado = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flechaHaEntrado)
		{
			if (Input.GetKeyDown(tecla))
			{
				textoResultado.text = textoResultante;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag.Equals("Flecha"))
		{
			flechaHaEntrado = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag.Equals("Flecha"))
		{
			flechaHaEntrado = false;
		}
	}
}
