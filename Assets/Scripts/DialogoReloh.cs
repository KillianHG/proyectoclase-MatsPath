using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoReloh : MonoBehaviour {

	public NpcTalk[] npcTalk = new NpcTalk[2];

	private bool dialogoConcluido = false;

	internal ControladorDialogoReloj controlDialogoR;

	public EslaHora reloj;

	// Use this for initialization
	void Start () {

		controlDialogoR = FindObjectOfType<ControladorDialogoReloj> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			if (!reloj.bien)
			{
			other.GetComponent<PlayerInput> ().speed = 0;

			

				if (!dialogoConcluido)
				{
					controlDialogoR.ProximoDialogo(npcTalk[0]);
				}
				else
				{
					controlDialogoR.ProximoDialogo(npcTalk[1]);
				}

				dialogoConcluido = true;
			}
		}
	}
}
