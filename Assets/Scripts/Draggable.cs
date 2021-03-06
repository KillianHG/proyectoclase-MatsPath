using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

	private bool selected;
	public GameObject pieza;
	public GameObject objetivo;
	private Vector2 initialPosition;

	void Start()
	{
		initialPosition = pieza.transform.position;
		print(initialPosition);
	}


	// Update is called once per frame
	void Update () {
		if (selected)
		{
			Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = new Vector2(cursorPos.x, cursorPos.y);
		}

		if (Input.GetMouseButtonUp(0))
		{
			drop();
			selected = false;
		}
	}

	private void OnMouseOver()
	{ 
		
		if (Input.GetMouseButtonDown(0))
		{
			selected = true; 
		}
	}
	
	public void drop()
	{
		if (pieza.tag.Equals(objetivo.tag))
		{
			float distancia = Vector2.Distance(pieza.transform.position, objetivo.transform.position);
			if (distancia < 1)
			{
				pieza.transform.position = objetivo.transform.position;
			}
			else
			{
				pieza.transform.position = initialPosition;
			}
		}
		else
		{
			pieza.transform.position = initialPosition;
		}
	}
}
