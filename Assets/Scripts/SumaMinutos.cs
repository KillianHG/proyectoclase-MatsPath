using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumaMinutos : MonoBehaviour {

	public Text minutos;

	// Use this for initialization
	
	public void SetHora(){
		int tiempo = int.Parse(minutos.text);
		if (tiempo < 59)
		{
			tiempo++;
		} else if (tiempo == 59)
		{
			tiempo = 0;
		}

		minutos.text = tiempo.ToString();
	}
}
