﻿using UnityEngine;
using System.Collections;

public class menu_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Jugar()
	{
		
		Application.LoadLevel("level1"); //esto sirve para que al darle al boton te vayas a la escena del primer nivel
	}
}
