using UnityEngine;
using System.Collections;

public class PlaneCounter : MonoBehaviour, IVisTriggerTarget {
	// these vars are shared across planes
	public int planeCount = 0;
	public float scaleXFactor = 1.0f;
	public float xPosRand = 1.0f;

    public void OnTriggered(float current, float previous, float difference, float adjustedDifference) {

        planeCount ++;
		scaleXFactor = Random.Range(0.9f, 2.5f);
		xPosRand = Random.Range(0.0f, 5.0f);

    }

}