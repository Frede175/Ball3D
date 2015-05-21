using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

	public Transform target;
	public Transform shootFrom;
	public GameObject laser;
	public float fireRate = 50f;
	private float rate = 0f;
	
	// Update is called once per frame
	void FixedUpdate () {
		RaycastHit hit;
		if (rate >= fireRate)
		{
			rate = 0f;
			if (Physics.Raycast (transform.position,  transform.TransformDirection(Vector3.down), out hit)) 
			{
				if (hit.transform.tag == "Player") 
				{
					shoot ();
				}
			}
		}
		else
			rate++;
	}

	void shoot()
	{
		GameObject pel = Instantiate(laser, shootFrom.position, transform.rotation ) as GameObject;
		pel.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.down) * 6000);

	}
}
