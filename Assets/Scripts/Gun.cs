using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject target;
	public float maxTurningRate = 30f;
	private Quaternion qTarget;


	void Start()
	{
		qTarget = target.transform.localRotation;
	}

	// Update is called once per frame
	void Update () {
		/* ---- This does not work ---- */
		Quaternion newRotation = Quaternion.LookRotation(transform.position - target.transform.position, Vector3.forward);
		newRotation.x = 0.0f;
		newRotation.y = 0.0f;
		transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * maxTurningRate);
		/* ---- This does not work ---- */
	}
}
