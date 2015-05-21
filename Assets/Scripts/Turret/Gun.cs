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
		Vector3 vT = target.transform.position - transform.position;
		Vector3 vTaim;
		vTaim.x = 0f;
		vTaim.y = vT.y;
		vT.y = 0f;
		vTaim.z = vT.magnitude;
		qTarget = Quaternion.LookRotation(vTaim, Vector3.up);
		transform.localRotation = Quaternion.RotateTowards(transform.localRotation, qTarget, maxTurningRate * Time.deltaTime);
	}
}
