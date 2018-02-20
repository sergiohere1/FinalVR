using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigurationScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		// Se recupera el valor de dirección IP almacenado en la configuración de la aplicación
		GameManager.ipAdress = PlayerPrefs.GetString(GameManager.IP_ADDRESS);

		GetComponent<Text>().text = GameManager.ipAdress;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
