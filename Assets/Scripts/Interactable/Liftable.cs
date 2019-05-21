using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liftable : Interactable
{
	
	public override void Interact()
	{
		if (interacting)
		{
			Unlift();
			gameObject.GetComponent<Collider2D>().enabled = true;
			interacting = false;
		}
		else
		{
			interacting = true;
			gameObject.GetComponent<Collider2D>().enabled = false;
		}
	}

	private void FixedUpdate()
	{
		if (interacting)
		{
			Lift();
		}
	}

	private void Lift()
	{
		gameObject.transform.position = new Vector2(player.transform.position.x,player.transform.position.y + 1f);
	}

	private void Unlift()
	{
		float offsetX = player.transform.GetChild(0).GetComponent<CircleCollider2D>().offset.x;
		float offsetY = player.transform.GetChild(0).GetComponent<CircleCollider2D>().offset.y;
		gameObject.transform.position = new Vector3(player.transform.position.x + offsetX, player.transform.position.y + offsetY);
	}
}
