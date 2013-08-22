using UnityEngine;
using System.Collections;

public class AberationControls : MonoBehaviour, IVisTriggerTarget  {
	Vignetting ca; 
	float myVal; 
	void Start(){
		ca = GetComponent<Vignetting>(); 

	} 
	// Use this for initialization
	 public void OnTriggered(float current, float previous, float difference, float adjustedDifference) {

					//ca.chromaticAberration = 150; 
					 


	 }

}
