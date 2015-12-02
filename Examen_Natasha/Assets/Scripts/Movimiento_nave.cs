using UnityEngine;
using System.Collections;

public class Movimiento_nave : MonoBehaviour {

	Rigidbody2D rg;
	public GameObject laser;
	public Vector2 fuerza_laser = new Vector2 (0,700);
	public float fuerza=200f;
	public float velocidad_nave = 1f;
	
	void Start () {
		rg = GetComponent<Rigidbody2D> (); 
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.A)) {
			mueve_izq ();
		}
		if (Input.GetKey (KeyCode.D)) {
			mueve_dch ();
		}
		if (Input.GetKey (KeyCode.Space)) {
			disparo ();
		}
	}



	void mueve_izq(){
	
		transform.localScale = (new Vector3(-1,1,1)); 
		rg.velocity = (new Vector2 (-(velocidad_nave), rg.velocity.y));
	}

	void mueve_dch(){
		transform.localScale = (new Vector3(1,1,1));
		rg.velocity = (new Vector2 ((velocidad_nave),rg.velocity.y));
	}

	void disparo(){
		GameObject nuevo_laser = (GameObject) Instantiate(laser, transform.position, transform.rotation);
		//fuerza_laser.y= new Vector2(0,200);
		nuevo_laser.GetComponent<Rigidbody2D>().AddForce(fuerza_laser);
	}

	void OnTriggerEnter2D (Collider2D objeto){
		//Debug.Log (objeto.transform.name);
		if (objeto.transform.tag == "enemigo") {
			Destroy (gameObject);
			Application.LoadLevel("menu_principal");
		}
	}
	
}