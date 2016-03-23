using UnityEngine;
using System.Collections;

public class Atirar : MonoBehaviour {

	public GameObject player;
	public GameObject colherPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CriarColher", 1f, 1f);
	}

	void CriarColher(){
		GameObject novaColher = (GameObject)Instantiate(colherPrefab,transform.position,transform.rotation);
		novaColher.rigidbody.velocity = (player.transform.position - this.transform.position).normalized * 10;
	}

	// Update is called once per frame
	void Update () {

	}

}