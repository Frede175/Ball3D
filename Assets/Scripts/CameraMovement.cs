using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	void FixedUpdate()
	{
		if (player != null)
			offset = transform.position - player.transform.position;
		else
			Destroy(gameObject);
	}

	// Update is called once per frame
	void LateUpdate () {
		if (!GameManager.instance.doingSetUp && player != null)
		{
			transform.position = player.transform.position + offset;
		}
	}
}
