using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minutos : MonoBehaviour {
	public Text clockText;
	public bool showSeconds;
	private int seconds;
	private int minutes;
	private DateTime time;
	// Use this for initialization
	void Start () {
		seconds = -1;
		minutes = -1;
	}
  
	// Update is called once per frame
	void FixedUpdate () {
		time = DateTime.Now;
		if (showSeconds)
		{
			if (seconds != time.Second)
			{
				UpdateText();
				seconds = time.Second;
			}
		}
		else
		{
			if (minutes != time.Minute)
			{
				UpdateText();
				minutes = time.Minute;
			}
		}     
	}
	void UpdateText()
	{
		clockText.text = time.Minute.ToString("D2");

	}
}
