using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {
	Rigidbody2D rg; 
	public float fuerza_enemigo=1f; //es
	public GameObject efecto;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rg.velocity = new Vector2 (0, fuerza_enemigo); 
	}

	void OnTriggerEnter2D (Collider2D objeto){
		//Debug.Log (objeto.transform.name);
		if (objeto.transform.tag == "laser") {
			GameObject e =(GameObject)Instantiate(efecto,transform.position, transform.rotation); //coges su gameobjet y en el instancias el efecto de la explosion al colisionar con el laser
			Destroy (e,0.9f); //se destruira en 9 segundos
			Destroy (gameObject); //y despues se destruira
		}
		if (objeto.transform.tag == "destructor") {
			Destroy (gameObject); //si la nave colisiona con el destructor muere
		}
	}
}
