using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(other);
			GameManager.instance.EndLevel();
		}
	}
}
