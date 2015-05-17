using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
			GameObject gm = GameObject.Find("GameManager");
			GameManager gameManager = gm.GetComponent<GameManager>();
			gameManager.addCoin();
		}
		
	}
}
