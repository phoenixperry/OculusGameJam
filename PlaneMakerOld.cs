using UnityEngine;
using System.Collections;

public class PlaneMakerOld : MonoBehaviour {
	// prefab we are using
	public GameObject myObj;
	public int index = 0;

	// get the current number of planes
	private GameObject pcObj;
	private PlaneCounter pc;
	private int _i = 0;

	// property vars
	private int _angle = 20;
	private int _distX = 20;
	private int _distY = 5;
	private int _distZ = 2;
	private float _startTime;
	
	// Use this for initialization
	void Start () {
		_startTime = Time.time;

		// calc some values
		float scaleXFactor = Random.Range(0.9f, 3.5f);
		float xPosRand = Random.Range(0.5f, 1.0f);

		// get current plane count
		pcObj = GameObject.Find("PlaneCounter") as GameObject;
		pc = pcObj.GetComponent<PlaneCounter>();

		// create objects
		GameObject newObj = Instantiate(myObj, transform.position, Quaternion.Euler(20*_i,270,90)) as GameObject;
		newObj.transform.RotateAround(Vector3.zero, Vector3.zero, 20 * _i);

		// mirrored object
		GameObject newObj_m = Instantiate(myObj, transform.position, Quaternion.Euler(-20*_i,270,90)) as GameObject;
		newObj_m.transform.RotateAround(Vector3.zero, Vector3.zero, -20 * _i);

		// add children to parent container myObj
		// newObj.transform.parent = this.transform;
		// newObj_m.transform.parent = this.transform;
			
		// position
		Vector3 pos = newObj.transform.position;
		float sinY = Mathf.Sin((Time.time-_startTime)*5)*3;
		pos.y = pos.y + (sinY*sinY);  // sinY squared undulates the y-pos
		pos.x = pos.x + xPosRand + _distX;
		pos.z = _i*_distZ;
		newObj.transform.position = pos;
			
		// scale
		float localScaleX = newObj.transform.localScale.x;
		Vector3 newScale = new Vector3(localScaleX - scaleXFactor , newObj.transform.localScale.y, newObj.transform.localScale.z);
		newObj.transform.localScale = newScale;

		// mirrored position
		Vector3 pos_m = newObj_m.transform.position;
		pos_m.y = pos_m.y + (sinY*sinY); // sinY squared undulates the y-pos
		pos_m.x = pos.x + xPosRand - _distX;
		pos_m.z = _i*_distZ;
		newObj_m.transform.position = pos_m;
			
		// mirrored scale
		float localScaleX_m = newObj_m.transform.localScale.x;
		Vector3 newScale_m = new Vector3(localScaleX_m - scaleXFactor , newObj_m.transform.localScale.y, newObj_m.transform.localScale.z);
		newObj_m.transform.localScale = newScale_m;
		
	}
}
