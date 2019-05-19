using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.UI;

public class SumaHoras : MonoBehaviour
{

	public Text hora;

	// Use this for initialization
	
	public void SetHora(){
		int tiempo = int.Parse(hora.text);
		if (tiempo < 23)
		{
			tiempo++;
		} else if (tiempo == 23)
		{
			tiempo = 0;
		}

		hora.text = tiempo.ToString();
	}

}
