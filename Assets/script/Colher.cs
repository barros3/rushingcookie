using UnityEngine;
using System.Collections;

public class Colher : MonoBehaviour {
	float tempoJogarColher = 0;

	public GameObject queijo;
	
	void Start(){}

	void Update(){

		/*
		tempoJogarColher++;
		
		if (tempoJogarColher == 100) {
			Instantiate(queijo,transform.position,transform.rotation);
			
			tempoJogarColher = 0;
		
			queijo.transform.Translate(0f,0f,-100f);

		}
		*/
	}

	
	void criarQueijo(){
		Instantiate (queijo);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player") {
						Application.LoadLevel (Application.loadedLevel);
		} else
						Destroy (this.gameObject);
	}

	void chamaQueijo(){
		Invoke (("criarQueijo"), (float) Random.Range(6,12));
	}
}