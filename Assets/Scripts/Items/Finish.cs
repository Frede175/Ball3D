using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			GameManager.instance.EndLevel();
		}
	}
}
