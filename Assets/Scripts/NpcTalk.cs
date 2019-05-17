using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NpcTalk : ScriptableObject {

	public string dialogo;

	public bool RespuestaCorrecta;

	public Respuesta[] respuestas;
}
