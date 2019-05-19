using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivarReloj : MonoBehaviour {

	public GameObject hora;

	public GameObject jugador;
	
	public PlayerInput pi;
	
	public Dialogo dialogoHora;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.E))
		{
			pi.speed = 0;
			hora.SetActive(true);
			
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.name);
		jugador = other.gameObject;
	}
}
