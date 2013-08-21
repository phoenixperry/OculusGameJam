using UnityEngine;
using System.Collections;

public class PlaneMaker : MonoBehaviour {
	// prefab we are using
	public GameObject myObj;
	// will cause object to mirror or not
	public int flip = 1;

	// get the current number of planes
	private GameObject pcObj;
	private PlaneCounter pc;
	private int _i = 0;
	private float _scaleXFactor = 1.0f;
	private float _xPosRand = 1.0f;
	private float _rotRand = 1.0f;

	// internal settings
	private int _angle = 20;
	private int _distX = 8;
	private int _distY = -5;
	private int _distZ = 2;

	// Use this for initialization
	void Start () {
		// get current plane count + rand vals
		pcObj = GameObject.Find("PlaneCounter") as GameObject;
		pc = pcObj.GetComponent<PlaneCounter>();
		_i = pc.planeCount;
		_scaleXFactor = pc.scaleXFactor;
		_xPosRand = pc.xPosRand;

		myObj.transform.rotation = Quaternion.Euler(flip * 20 * _i, 270, 90);
		myObj.transform.RotateAround(Vector3.zero, Vector3.zero, flip * 20 * _i);

		// position
		Vector3 pos = myObj.transform.position;
		float sinY = Mathf.Sin((Time.time-_i)*5)*3;
		pos.y = pos.y + (sinY*sinY);  // sinY squared undulates the y-pos
		pos.x = pos.x + _xPosRand + (flip*_distX);
		pos.z = _i*_distZ;
		myObj.transform.position = pos;
			
		// scale
		float localScaleX = myObj.transform.localScale.x;
		Vector3 newScale = new Vector3(localScaleX - _scaleXFactor , myObj.transform.localScale.y, myObj.transform.localScale.z);
		myObj.transform.localScale = newScale;

		// add children to parent container myObj
		// newObj.transform.parent = this.transform;
		
	}
}
