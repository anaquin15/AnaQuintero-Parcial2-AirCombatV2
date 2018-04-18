using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MISSILE : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Destroy (this.gameObject,8);
	}
	
	// Update is called once per frame
	void Update () {

		// mover hacia delante
		this.transform.Translate (0.0f, 10.0f, 0.0f );
		
	}

	void OnCollisionEnter(Collision collision) {

		// = Asignar
		//==Preguntar

		if (collision.collider.gameObject.tag == "MarsAlien") {


		// Carga el prefab de una explosion Mars

			GameObject MarsExplosion = GameObject.Instantiate(Resources.Load ("Prefabs/MarsExplosion") as GameObject);
			
			//Muevo la explisii=on a la posicion donde esta la nave

			MarsExplosion.transform.position = collision.collider.gameObject.transform.position;

		// Cuando el misil colision con la plataforma
		// La elimina

		Destroy (collision.collider.gameObject);

		//Destruir el misil

		Destroy (this.gameObject);
		}

		if (collision.collider.gameObject.tag == "JupiterAlien") {

			// Carga el prefab de una explosion Mars

			GameObject JupiterExplosion = GameObject.Instantiate(Resources.Load ("Prefabs/JupiterExplosion") as GameObject);

			//Muevo la explisii=on a la posicion donde esta la nave

			JupiterExplosion.transform.position = collision.collider.gameObject.transform.position;

			// Cuando el misil colision con la plataforma
			// La elimina

			Destroy (collision.collider.gameObject);

			//Destruir el misil

			Destroy (this.gameObject);
	
		}
	
	}
}
