using UnityEngine;
using System.Collections;

public class puntosEnemigo : MonoBehaviour {

	public int naves_suma= 0; //valor para aumentar los puntos que se iran sumando
	public bool destruye = true; //si se activa se destruye el objeto si el jugador lo toca
	private puntuacion gp; // llama al script gestionpuntos
	
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.transform.tag == "Player"){
			gp= objeto.gameObject.GetComponent<puntuacion>(); //accede a este componente para llamar a la funcion de dentro y cambiar los puntos
	

		}
	}

}
