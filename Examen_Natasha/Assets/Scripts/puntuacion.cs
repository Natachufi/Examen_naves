using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class puntuacion : MonoBehaviour {
	public Text texto_puntos;
	public int puntos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void suma_puntos(int puntos_nuevos)
	{
		puntos = puntos + puntos_nuevos; // suma a puntos el nuevo valor de puntos que vaya gestionando
		texto_puntos.text = ""+puntos; //muestra los puntos en el texto
//		Enemigo.SetBool("DarEnemigo", true);

	}
}
