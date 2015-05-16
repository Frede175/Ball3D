using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class PickupCapsule : MonoBehaviour {

	public float minSpeed = 10f;
	public float maxSpeed = 60f;
	public float minTime = 4f; 
	public float maxTime = 20f;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
			PlayerMovement playerScript = other.GetComponent<PlayerMovement>();
			playerScript.playerEffectSpeed(Random.Range(minSpeed, maxSpeed), Random.Range(minTime, maxTime));

		}

	}
}
