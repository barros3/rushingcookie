using UnityEngine;
using System.Collections;

public class UnitPlayer : Unit {

	// Use this for initialization
	public override void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	public override void Update () {
		//rotaçao
		transform.Rotate(0f, Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime, 0f);

		//movimentaçao
		move = new Vector3 (Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical")); 
		move.Normalize ();
		move = transform.TransformDirection (move);
		base.Update ();
	
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "queijo")
		Destroy (col.gameObject);
		}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "enemy") {
			Application.LoadLevel("gameover");
		}
	}
}
