using UnityEngine;
using System.Collections;

public class Moeda : MonoBehaviour 
{
	public int valor;
	public bool atraivel = false;
	private float smooth = 1f;
	
	void Awake()
	{
		if (valor == 0) valor = 5;
	}
	
	
	void Update () 
	{
		if (valor > 0 && atraivel == true) transform.position = Vector3.Lerp(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, Time.deltaTime * smooth);
	}
}