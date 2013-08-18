using UnityEngine;
using System.Collections;

public class S_RandomPopulator : MonoBehaviour {
	public float maxPos = 50.0f; 
	public float minPos = 3.0f;

	public GameObject myObj;
	public int max = 5;

	private float _delay = 1.0f;
	private int _angle = 20;
	private int _coin = 1;
	private int _dist = 5;
	private float _dpth = 0.1f;
	private float _incr = 5f;
	private float _startTime;

	// Use this for initialization
	void Start () {
		_startTime = Time.time;

		StartCoroutine(spawn());
	}
	
	IEnumerator spawn(){

		for(float i=0; i < max; i++){
			// interval of time
			yield return new WaitForSeconds(_delay);

			float scaleXFactor = (_coin*Random.Range(0.8f, 2.0f));
			float xPosRand = Random.Range(1.0f, 3.0f);

			// create objects
			GameObject newObj = Instantiate(myObj, transform.position, Quaternion.Euler(20*i,270,90)) as GameObject;
			newObj.transform.RotateAround(Vector3.zero, Vector3.forward, 20 * i);
			// mirrored object
			GameObject newObj_m = Instantiate(myObj, transform.position, Quaternion.Euler(-20*i,270,90)) as GameObject;
			newObj_m.transform.RotateAround(Vector3.zero, Vector3.forward, -20 * i);

			//parent
			newObj.transform.parent = this.transform;
			newObj_m.transform.parent = this.transform;
			// position
			Vector3 pos = newObj.transform.position;
			float sinY = Mathf.Sin((Time.time-_startTime)*5)*3;
			pos.y = 8.0f + sinY;//pos.y + (incr*i);
			pos.x = xPosRand + _dist;
			pos.z = _dpth*i*2;
			//newObj.transform.position = pos;
			
			// scale
			float localScaleX = newObj.transform.localScale.x;
			Vector3 newScale = new Vector3(localScaleX - scaleXFactor , newObj.transform.localScale.y, newObj.transform.localScale.z);
			// newObj.transform.localScale = newScale;
			
			

			// position
			Vector3 pos_m = newObj_m.transform.position;
			pos_m.y = 8.0f + sinY;//pos_m.y + (incr*i);
			pos_m.x = xPosRand - _dist;
			pos_m.z = _dpth*i*2;
			//newObj_m.transform.position = pos_m;
			
			// scale
			float localScaleX_m = newObj_m.transform.localScale.x;
			Vector3 newScale_m = new Vector3(localScaleX_m - scaleXFactor , newObj_m.transform.localScale.y, newObj_m.transform.localScale.z);
			//newObj_m.transform.localScale = newScale_m;
			
			// add children to parent container
				} 
	}
}
