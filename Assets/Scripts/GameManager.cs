using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int numberOfCoinsInLevel;

	int numberOfCoins = 0;
	int pickedupCoins = 0;

	void Start()
	{
		numberOfCoins = numberOfCoinsInLevel;
	}


	public void addCoin()
	{
		Debug.Log ("Number of: " + numberOfCoins + ", pickedupCoins: " + pickedupCoins);
		if (pickedupCoins < numberOfCoins)
			pickedupCoins++;
		else 
			Debug.Log ("Error coins");
	}

	public void endLevel()
	{

	}
}
