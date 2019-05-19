using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestaHoras : MonoBehaviour {

	public Text hora;

	// Use this for initialization
	
	public void SetHora(){
		int tiempo = int.Parse(hora.text);
		if (tiempo > 0)
		{
			tiempo--;
		} else if (tiempo == 0)
		{
			tiempo = 23;
		}

		hora.text = tiempo.ToString();
	}
}
