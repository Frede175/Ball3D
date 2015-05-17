using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			GameManager.instance.Restart();

		}
	}
}
