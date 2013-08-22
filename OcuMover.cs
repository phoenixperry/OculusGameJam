using UnityEngine;
using System.Collections;
 
public class OcuMover : MonoBehaviour {
	public float moveSpeed= 15.0f; 
//	public GameObject oculusValueExtrator; 
	public Camera leftCam;

//	private Vector3 current_position; 
//	private Quaternion current_rotation;
	// Use this for initialization
	void Start () {
//		oculusValueExtrator = GameObject.Find("OcuValueExtractor"); 
//		current_position = leftCam.GetComponent<Transform>().position; 
	}
	// Update is called once per frame
		void Update () {
		//float zpos = Time.deltaTime*moveSpeed; 
		//Vector3 fwd = transform.TransformDirection(Vector3.forward); 
		
		// current_rotation = leftCam.GetComponent<Transform>().rotation; 
		//checkPosition();
		
		//must be quaterion * vect to work for overload but this will move the oculus with the rotation 
		Vector3 fwd = leftCam.GetComponent<Transform>().rotation * Vector3.forward  * (Time.deltaTime *moveSpeed);  
				 //fwd = fwd*-1; 
				 Rigidbody  myBody = GetComponent<Rigidbody>() as Rigidbody;
				 myBody.AddForce(fwd);
 
	
	}
	//holy shit the long way around 
	// void checkPosition(){
	// 	//straight forward on  x  
	// 	if((current_rotation.eulerAngles.x >=0)&& 
	// 		(current_rotation.eulerAngles.x <=17)) 
			
	// 		{

	// 		 if((current_rotation.eulerAngles.y >=0 ) &&
	// 		 	(current_rotation.eulerAngles.y <=4 ) ||
	// 		 	(current_rotation.eulerAngles.y >= 350) &&
	// 		 	(current_rotation.eulerAngles.y <=360)) {
			 	
	// 				Debug.Log("xStraight " + "looking Straightish");
	// 				current_position.z += moveSpeed; 
	// 			 } 

	// 		else if((current_rotation.eulerAngles.y >= 170) && 
	// 		 	(current_rotation.eulerAngles.y <= 186)){

	// 				Debug.Log("xStraight " + "looking back"); 
	// 				current_position.z -= moveSpeed; 
	// 		 	}
			 		 
	// 		 else if((current_rotation.eulerAngles.y >= 5) && 
	// 		 	(current_rotation.eulerAngles.y <= 90)){

	// 				Debug.Log("xStraight " + "looking right forward"); 
	// 		 		current_position.x +=moveSpeed;
	// 				current_position.z += moveSpeed; 
	// 		 	}

	// 		 else if((current_rotation.eulerAngles.y > 92) && 
	// 		 	(current_rotation.eulerAngles.y <= 191)) 
	// 			{

	// 				Debug.Log("xStraight " + "back left");
	// 		 		current_position.x -=moveSpeed;
	// 				current_position.z -= moveSpeed; 

	// 			} 

	// 		 else if((current_rotation.eulerAngles.y > 193) && 
	// 		 	(current_rotation.eulerAngles.y <= 262)) 
	// 			{

	// 				Debug.Log("xStraight " + "back right"); 
	// 		 		current_position.x +=moveSpeed;
	// 				current_position.z -= moveSpeed; 

	// 			}

	// 		 else if((current_rotation.eulerAngles.y >= 265) && 
	// 		 	(current_rotation.eulerAngles.y <= 349)) 
	// 		 	{

	// 				Debug.Log("xStraight " + "left forward"); 
	// 				current_position.x -=moveSpeed;
	// 				current_position.z += moveSpeed; 


	// 		 	} 	
	// 		 else{
	// 		 		Debug.Log("xStraight " + "looking god knows where"); 
	// 		 	} 	 
			
	// 	}
		
	// 	//looking up on x 
	// 	if((current_rotation.eulerAngles.x <=350)&& 
	// 	(current_rotation.eulerAngles.x >=270)) 
	// 		{

	// 		 if((current_rotation.eulerAngles.y >=0 ) &&
	// 		 	(current_rotation.eulerAngles.y <=4 ) ||
	// 		 	(current_rotation.eulerAngles.y >= 350) &&
	// 		 	(current_rotation.eulerAngles.y <=360)) {

	// 			Debug.Log("xUp" + "looking Straightish");
		
	// 			 } 

	// 		 else if((current_rotation.eulerAngles.y >= 5) && 
	// 		 	(current_rotation.eulerAngles.y <= 90)){

	// 			Debug.Log("xxUp" + "looking right forward"); 
	// 		 	}

	// 		 else if((current_rotation.eulerAngles.y > 92) && 
	// 		 	(current_rotation.eulerAngles.y <= 191)) 
	// 			{

	// 				Debug.Log("xUp " + "back left"); 
	// 			} 

	// 		 else if((current_rotation.eulerAngles.y > 193) && 
	// 		 	(current_rotation.eulerAngles.y <= 262)) 
	// 			{

	// 				Debug.Log("xUp " + "back right"); 
	// 			}

	// 		 else if((current_rotation.eulerAngles.y >= 265) && 
	// 		 	(current_rotation.eulerAngles.y <= 349)) 
	// 		 	{

	// 				Debug.Log("xUp " + "left forward"); 
	// 		 	} 	
	// 		 else{
	// 		 		Debug.Log("xUp " + "looking god knows where"); 
	// 		 	} 	 
			
	// 	}

	// 	//looking DOWN on x 
	// 	if((current_rotation.eulerAngles.x >=15)&& 
	// 	(current_rotation.eulerAngles.x <=80)) 
	// 		{

	// 		 if((current_rotation.eulerAngles.y >=0 ) &&
	// 		 	(current_rotation.eulerAngles.y <=4 ) ||
	// 		 	(current_rotation.eulerAngles.y >= 350) &&
	// 		 	(current_rotation.eulerAngles.y <=360)) {

	// 			Debug.Log("xDown" + "looking Straightish");
		
	// 			 } 

	// 		 else if((current_rotation.eulerAngles.y >= 5) && 
	// 		 	(current_rotation.eulerAngles.y <= 90)){

	// 			Debug.Log("xDown "+ "looking right forward"); 
	// 		 	}

	// 		 else if((current_rotation.eulerAngles.y > 92) && 
	// 		 	(current_rotation.eulerAngles.y <= 191)) 
	// 			{

	// 				Debug.Log("xDown " + "back left"); 
	// 			} 

	// 		 else if((current_rotation.eulerAngles.y > 193) && 
	// 		 	(current_rotation.eulerAngles.y <= 262)) 
	// 			{

	// 				Debug.Log("xDown " + "back right"); 
	// 			}

	// 		 else if((current_rotation.eulerAngles.y >= 265) && 
	// 		 	(current_rotation.eulerAngles.y <= 349)) 
	// 		 	{

	// 				Debug.Log("xDown " + "left forward"); 
	// 		 	} 	
	// 		 else{
	// 		 		Debug.Log("xDown " + "looking god knows where"); 
	// 		 	} 	 
			

	// }

}
