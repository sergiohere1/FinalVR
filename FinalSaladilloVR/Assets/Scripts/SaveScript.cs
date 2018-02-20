using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScript : MonoBehaviour
{
	/// <summary>
	/// Objeto con la dirección IP introducida por el usuario
	/// </summary>
	public Text ipAdress;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// Método que se ejecuta cuando se pulsa el botón save
	/// </summary>
	/// <remarks>
	/// Obtiene la dirección IP introducida por el usuario y la guarda en las preferencias de la aplicación.
	/// </remarks>
	public void Click()
	{
		// Se obtiene la dirección IP introducida por el usuario
		GameManager.ipAdress = ipAdress.GetComponent<Text>().text;
		// Se guarda la dirección IPS
		PlayerPrefs.SetString(GameManager.IP_ADDRESS, GameManager.ipAdress);
		// Se almacena el valor en la configuración de la aplicación
		PlayerPrefs.Save();
	}
}
