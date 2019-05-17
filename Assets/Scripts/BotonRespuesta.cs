using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonRespuesta : MonoBehaviour {

	Respuesta respuestaData;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ProximoDialogo()
	{
		FindObjectOfType<ControladorDialogo> ().ProximoDialogo (respuestaData.proximoDialogo);
	}
	public void Setup(Respuesta respuesta)
	{
		respuestaData = respuesta;

	}
}
