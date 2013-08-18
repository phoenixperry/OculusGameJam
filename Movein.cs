using UnityEngine;
using System.Collections;

public class Movein : MonoBehaviour {
	public float moveSpeed= 1.0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float zpos = Time.deltaTime*moveSpeed; 
		Vector3 fwd = transform.TransformDirection(Vector3.forward); 
	
		 
		transform.Translate(0,0,zpos); 
	}
}
