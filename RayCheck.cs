using UnityEngine;
using System.Collections;

public class RayCheck : MonoBehaviour {
	//object to check if hit
	public AudioClip sound; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward_ = transform.TransformDirection(Vector3.forward); 
		RaycastHit hit;
		Color myColor = new Color(1, 0, 0, 1); 
		Debug.DrawRay(transform.position, forward_,myColor, 10.0f ); 

		//also try out vs forward
		if(Physics.Raycast(transform.position, forward_, out hit, 10)){
					//Debug.Log("in zone1");
			Debug.Log(hit.collider.gameObject.name);
			if(hit.collider.gameObject.tag =="zone1"){
				//play audio
				Debug.Log("in zone1");
				hit.collider.gameObject.audio.Play();
			} 
		}
	}
}
