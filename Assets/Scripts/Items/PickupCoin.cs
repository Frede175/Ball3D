﻿using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour {



	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
			GameManager.instance.AddCoin();
		}
		
	}
}
