using UnityEngine;
using System.Collections;

public class visualEffectsTransparent : MonoBehaviour {
	private float xTiling; 
	public float min = 0; 
	public float max =100;
	private float scaleX; 
	private float scaleY; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// scaleY = Mathf.Sin(Time.time)*0.5F +1; 
		// scaleX = Mathf.Cos(Time.time)*0.5F +1; 
		// renderer.material.shader = Shader.Find("Transparent/Diffuse"); 
		// renderer.material.color = Color.white;
	 //    renderer.material.mainTextureScale = new Vector2(scaleX*50, scaleY*3);
	 //    renderer.material.color = Color.white;
	}
}
