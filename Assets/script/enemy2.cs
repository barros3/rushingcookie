using UnityEngine;
using System.Collections;

public class enemy2 : MonoBehaviour {
	
	float velocidade;
	float distance;
	
	public Transform target;
	
	float range2 = 3;
	float range =100;
	float stop = 1;
	
	
	Transform myTransform;
	
	public int moveSpeed = 2;
	int rotationSpeed = 15;

	void Awake(){
		myTransform = transform;
	}

	void Start () {
		
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		
	}
	
	void Update () {
		//rotacionar e olhar pro jogador
		distance = Vector3.Distance(myTransform.position, target.position);
		
		
		if (distance<=range2 && distance>=range){
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			                                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		}
		
		else if(distance<=range && distance>stop){
			//mover-se para o jogador
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			                                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}
		else if (distance<=stop) {
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			                                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		}
		
	}
}