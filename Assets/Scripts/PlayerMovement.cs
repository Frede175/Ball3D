using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed = 2F;

	private Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		float horizontal = Input.GetAxis("Horizontal") * playerSpeed;
		float vertical = Input.GetAxis("Vertical") * playerSpeed;

		Vector3 movement = new Vector3(horizontal, 0f, vertical);

		rb.AddForce(movement);

	}
}
