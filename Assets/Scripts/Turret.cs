using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	public GameObject target;
	public float maxTurningRate = 30f;
	private Quaternion qTarget;

	// Update is called once per frame
	void Update () {
		Vector3 vT = target.transform.position - transform.position;
		vT.y = transform.position.y;
		qTarget = Quaternion.LookRotation(Vector3.up, vT);
		qTarget *= Quaternion.Euler(0, 0, 90);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, qTarget, maxTurningRate * Time.deltaTime);
	}
}
