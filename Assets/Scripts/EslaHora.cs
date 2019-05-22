using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EslaHora : MonoBehaviour
{

	public String minutosAns;

	public String horasAns;
	
	public Text minutos;

	public Text horas;

	private bool aux1;

	private bool aux2;

	public GameObject reloj;

	public bool bien;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void comprobar()
	{
		if (minutosAns.Equals(minutos.text))
		{
			aux1 = true;
		}

		if (horasAns.Equals(horas.text))
		{
			aux2 = true;
		}

		print(aux1 +""+ aux2);
		
		if (aux1 && aux2)
		{
			print("BUENA");
			reloj.SetActive(false);
			bien = true;
		}
	}
	
}
