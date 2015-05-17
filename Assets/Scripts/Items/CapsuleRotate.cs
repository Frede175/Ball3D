using UnityEngine;
using System.Collections;

public class CapsuleRotate : MonoBehaviour {

	public float x_speed = 100f;
	public float y_speed = 50f;
	public float z_speed = 100f;
	
	// Update is called once per frame
	void Update () {

		if (x_speed < 100)
		{
			x_speed += 2;
		}
		else
		{
			x_speed = 50;
		}

		Vector3 rotate = new Vector3(x_speed, y_speed, z_speed);
		transform.Rotate(rotate * Time.deltaTime);
	}
}
