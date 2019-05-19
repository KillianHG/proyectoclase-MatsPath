using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour {

	public NpcTalk[] npcTalk = new NpcTalk[2];

	private bool dialogoConcluido = false;

	internal ControladorDialogo controlDialogo;

	// Use this for initialization
	void Start () {

		controlDialogo = FindObjectOfType<ControladorDialogo> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			other.GetComponent<PlayerInput> ().speed = 0;

			if (!dialogoConcluido) {
				controlDialogo.ProximoDialogo (npcTalk[0]);
			} else 
			{
				controlDialogo.ProximoDialogo (npcTalk [1]);
			}
			dialogoConcluido = true;
		}
	}
}
