using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControladorDialogo : MonoBehaviour {

	public GameObject PanelDialogo;
	public Text dialogoNPC;

	public GameObject Respuesta;

	private bool DialogoActivo = false;

	NpcTalk dialogos;

	public GameObject moneda;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && DialogoActivo) {

			if (dialogos.respuestas.Length > 0) {
				MostrarRespuestas ();
			} else {
				DialogoActivo = false;
				PanelDialogo.SetActive (false);
				dialogoNPC.gameObject.SetActive (false);
				FindObjectOfType<PlayerInput> ().speed = 5;
			}
		}

	}

	void MostrarRespuestas()
	{
		dialogoNPC.gameObject.SetActive (false);
		DialogoActivo = false;

		for (int i = 0; i< dialogos.respuestas.Length;i++)
		{
			GameObject tempRespuesta = Instantiate (Respuesta, PanelDialogo.transform) as GameObject;
			tempRespuesta.GetComponent<Text>().text = dialogos.respuestas [i].respuesta;
			tempRespuesta.GetComponent<BotonRespuesta> ().Setup (dialogos.respuestas[i]);
			tempRespuesta.GetComponent<Button> ().onClick.RemoveAllListeners ();
			int index = i;
			tempRespuesta.GetComponent<Button> ().onClick.AddListener (delegate {
				if (dialogos.respuestas[index].proximoDialogo.RespuestaCorrecta){
					print("A");
					print(moneda.activeSelf);
					moneda.SetActive(true);
					print(moneda.activeSelf);	
					print("---");
				} 

				ProximoDialogo(dialogos.respuestas[index].proximoDialogo);
			});
		}

	}

	public void ProximoDialogo(NpcTalk dialogo)
	{
		dialogos = dialogo;

		LimpiarRespuestas ();

		DialogoActivo = true;
		PanelDialogo.SetActive (true);
		dialogoNPC.gameObject.SetActive (true);

		dialogoNPC.text = dialogos.dialogo;
	}

	void LimpiarRespuestas()
	{
		BotonRespuesta[] botones = FindObjectsOfType<BotonRespuesta> ();
		foreach (BotonRespuesta boton in botones) {
			Destroy (boton.gameObject);
		}
	}

}
