using UnityEngine;
using System.Collections;

public class laserTimer : MonoBehaviour {

	public float alive = 250f;
	private float count = 0f;
	
	// Update is called once per frame
	void FixedUpdate () {
		count++;
		if (count == alive)
			Destroy(gameObject);

	}
}
