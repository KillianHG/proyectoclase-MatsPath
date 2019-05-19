using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestaMinutos : MonoBehaviour {

	public Text minutos;

	// Use this for initialization
	
	public void SetHora(){
		int tiempo = int.Parse(minutos.text);
		if (tiempo > 0)
		{
			tiempo--;
		} else if (tiempo == 0)
		{
			tiempo = 59;
		}

		minutos.text = tiempo.ToString();
	}
}
