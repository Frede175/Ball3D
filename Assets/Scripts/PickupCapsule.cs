using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class PickupCapsule : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);

			GameObject player = GameObject.FindWithTag("Player");
			PlayerMovement playerScript = player.GetComponent<PlayerMovement>();
			playerScript.playerSpeed = Random.Range(10f, 100f);
			Debug.Log(playerScript.playerSpeed);
		}

	}
}
