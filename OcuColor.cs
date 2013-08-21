using UnityEngine;
using System.Collections;
using System.IO; 
using System.Text; 
public class OcuColor : MonoBehaviour {
	
	public Camera leftCam; 
	public Camera rightCam; 
	public GameObject ocuWhole; 

	public GameObject plane; 
	
	private string path; 
	private float maxX; 
	private float maxY; 
	private float maxZ;  


	private float minX; 
	private float minY; 
	private float minZ;  

	private Quaternion leftVect; 
	private string fileName; 
	FileStream fs; 
	//you are going to need an array list to pull all planes but for now... 
	// Use this for initialization
	void Start () {
		 leftVect = leftCam.GetComponent<Transform>().rotation;
		 //rotation = leftVect.x; 
		 maxY = leftVect.y; 
		 maxZ = leftVect.z; 
		 minX = leftVect.x; 
		 minY = leftVect.y; 
		 minZ = leftVect.z;  
		 fileName = "/oculusData.txt";
	}
	
	// Update is called once per frame
	void Update () {

		//GET THE CAMERA VALUES
		leftVect = leftCam.GetComponent<Transform>().rotation; 
		if(leftVect.x > maxX) maxX = leftVect.x; 
		if(leftVect.y > maxY) maxY = leftVect.y; 
		if(leftVect.z > maxZ) maxZ = leftVect.z; 

		if(leftVect.x < minX) minX = leftVect.x; 
		if(leftVect.y < minY) minY = leftVect.y; 
		if(leftVect.z < minZ) minZ = leftVect.z; 

		//Debug.Log("x is" +leftVect.x + "y is" + leftVect.y+ "z is"+ leftVect.z); 
		// leftVect.x = Mathf.Clamp(leftVect.x, 0.0f, 1.0f);
		// leftVect.y = Mathf.Clamp(leftVect.y, 0.0f, 0.2f);
		// leftVect.z= Mathf.Clamp(leftVect.z, 0.0f, 1.0f);
		//leftVect.x +=0.2f;
		//Debug.Log("x is" +leftVect.x%1 + "y is" + uint(leftVect.y%1)+ "z is"+ leftVect.z%1); 
		
		float numX = scaleRange(leftVect.x, -1, 1, 0,1); 
		float numY = scaleRange(leftVect.y, -1, 1, 0,1); 
		float numZ = scaleRange(leftVect.z, -1, 1, 0,1); 

		plane.gameObject.GetComponent<Renderer>( ).material.color = new Color( numX, numY, numZ);

		//Debug.Log(leftVect.x + "is the input val");

		path = Application.dataPath +fileName; 

		using(fs= File.Create(path)){
			AddText(fs, maxX.ToString()); 
			AddText	(fs, "is the maxX \n"); 
			
			AddText(fs, maxY.ToString()); 
			AddText	(fs, "is the maxY \n"); 

			AddText(fs, maxZ.ToString()); 
			AddText	(fs, "is the maxZ \n"); 

			AddText(fs, minX.ToString()); 
			AddText	(fs, "is the minX \n"); 
			
			AddText(fs, minY.ToString()); 
			AddText	(fs, "is the minY \n"); 

			AddText(fs, minZ.ToString()); 
			AddText	(fs, "is the minZ \n"); 

			//Debug.Log("endTest " + minZ)
;
			// AddText(fs, leftVect.x.ToString());
			// AddText(fs, " is the x value \n");
			// AddText(fs, leftVect.y.ToString());
			// AddText(fs, " is the y value \n"); 
			// AddText(fs, leftVect.z.ToString());
			// AddText(fs, " is the z value \n");
		}

	//	plane.gameObject.GetComponent<Renderer>( ).material.color = new Color( leftVect.x, leftVect.y , leftVect.z  );
		
	}


	float scaleRange(float value, float inputMin, float inputMax, float outputMin, float outputMax){

		value =  value - inputMin; 
		float scaled =   (outputMax-outputMin)/(inputMax-inputMin); 
		//Debug.Log(scaled + " i am the scale"); 
		value = value * scaled;
		value = value + outputMin; 
		//Debug.Log(value + "i am the val"); 
		return value; 

	} 

	private static void AddText(FileStream fs, string value){
		byte[] info = new UTF8Encoding(true).GetBytes(value); 
		fs.Write(info,0, info.Length); 

	}

}
