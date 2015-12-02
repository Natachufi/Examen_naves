using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {
	Rigidbody2D rg;
	public float fuerza_enemigo=1f;
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
			Destroy (gameObject);
		}
		if (objeto.transform.tag == "destructor") {
			Destroy (gameObject);
		}
	}
}
