using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColetarItens : MonoBehaviour {

	public Text pontuacao;
	public int pontos;

	// Use this for initialization
	void Start () {

		pontos = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
			pontuacao.text = "Pontos: " + pontos;

	}

	void OnTriggerEnter (Collider other){

	if (other.tag == "pegar") {
			other.gameObject.SetActive(false);
			pontos = pontos + 1;
		}
	
	}

}
