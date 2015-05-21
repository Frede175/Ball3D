using UnityEngine;
using System.Collections;

public class LaserRender : MonoBehaviour {

	LineRenderer line;

	// Use this for initialization
	void Start () {
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position,  transform.TransformDirection(Vector3.forward), out hit)) 
		{
			if (hit.transform.tag == "Player") 
			{
				StopCoroutine("FireLaser");
				StartCoroutine("FireLaser");
			}
		}
	}

	IEnumerator FireLaser()
	{
		line.enabled = true;
		RaycastHit hit;
		Ray ray = new Ray(transform.position,  transform.TransformDirection(Vector3.forward));

		while (Physics.Raycast (ray, out hit)) 
		{
			Debug.DrawRay(transform.position,  transform.TransformDirection(Vector3.forward));
			if (hit.transform.tag == "Player") 
			{
				line.SetPosition(0, ray.origin);
				line.SetPosition(1, hit.point);

			}
			else
				break;

			yield return null;

		}


		line.enabled = false;
	}
}
