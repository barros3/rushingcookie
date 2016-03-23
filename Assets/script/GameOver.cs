using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Texture texture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnGUI () {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), texture);

		if (GUI.Button (new Rect (Screen.width * 0.1f, Screen.height * 0.8f, Screen.width / 3, Screen.height / 10), "CONTINUE")) {
			Application.LoadLevel("cena1");
		}

		if (GUI.Button (new Rect (Screen.width * 0.6f, Screen.height * 0.8f, Screen.width / 3, Screen.height / 10), "MENU INICIAL")) {
			Application.LoadLevel("menuinicial");		
		}

	}
} 