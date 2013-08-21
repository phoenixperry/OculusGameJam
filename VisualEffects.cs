using UnityEngine;
using System.Collections;

public class VisualEffects : MonoBehaviour {
	
	GameObject plane;  
	private float xTiling; 
	public float min = 0; 
	public float max =100;
	private float scaleX; 
	private float scaleY; 
	// Use this for initialization
	void Start () {

		plane = GameObject.Find("BwPlane");
		//xTiling = Mathf.Random(); 
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3(Mathf.Lerp(min, max, Time.time),0,0); 
		scaleY = Mathf.Sin(Time.time)*0.5F +1; 
		scaleX = Mathf.Cos(Time.time)*0.5F +1; 
		renderer.material.shader = Shader.Find("Custom/BasicDiffuse"); 
		renderer.material.color = Color.white;
		renderer.material.mainTextureScale = new Vector2(scaleX*100, 1);

	}
}
