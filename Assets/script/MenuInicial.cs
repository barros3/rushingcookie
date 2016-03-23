using UnityEngine;
using System.Collections;

public class MenuInicial : MonoBehaviour {

	public GUISkin perSkin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 
	void OnGUI () {

		GUI.skin = perSkin;

		if (GUI.Button (new Rect (Screen.width * 0.55f, Screen.height * 0.6f, Screen.width / 3, Screen.height / 10), "PLAY")) {
			Application.LoadLevel("cena1");
		}
		
		if (GUI.Button (new Rect (Screen.width * 0.55f, Screen.height * 0.8f, Screen.width / 3, Screen.height / 10), "SAIR")) {
			Application.Quit();		
		}
	}
}
