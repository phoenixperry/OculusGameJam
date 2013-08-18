using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime; 
		float z = Input.GetAxis("Vertical") *Time.deltaTime; 
		transform.Translate(x, 0,z);
	}
}
