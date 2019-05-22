using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDetect : MonoBehaviour
{

	public GameObject player;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.GetComponent<Interactable>() && player.GetComponent<PlayerInput>().interactable == null)
		{
			player.GetComponent<PlayerInput>().canInteract = true;
			other.gameObject.GetComponent<Interactable>().player = player;
			player.GetComponent<PlayerInput>().interactable = other.gameObject.GetComponent<Interactable>();
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.GetComponent<Interactable>())
		{
			if (!other.gameObject.GetComponent<Interactable>().interacting)
			{
				player.GetComponent<PlayerInput>().canInteract = false;
				other.gameObject.GetComponent<Interactable>().player = null;
				player.GetComponent<PlayerInput>().interactable = null;
			}
		}
	}

}
