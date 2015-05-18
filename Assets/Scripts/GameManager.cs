using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public int numberOfLevels;
	public bool doingSetUp = false;


	float levelWait = 2f;
	int numberOfCoins = 0;
	public int pickedupCoins = 0;
	public static int level = 0;


	void Start()
	{
		doingSetUp = true;
		DontDestroyOnLoad (gameObject);
		instance = this;
		InitGame();


	}

	void OnLevelWasLoaded(int index)
	{
		if (index == 0)
			Destroy(gameObject);
		level++;
		InitGame();
	}

	void InitGame()
	{
		//Setup
		doingSetUp = true;
		

		UIScript.instance.levelText.text = "Level " + level;
		UIScript.instance.levelScreen.SetActive(true);
		GameObject[] coins;
		coins = GameObject.FindGameObjectsWithTag("Coin");
		numberOfCoins = coins.Length;
		pickedupCoins = 0;
		UpdateText();
		UIScript.instance.finish.SetActive(false);


		Invoke("HideLevelScreen", levelWait);

	}



	public void AddCoin()
	{
		if (pickedupCoins < numberOfCoins)
		{
			pickedupCoins++;
			UpdateText();
			if (pickedupCoins == numberOfCoins)
			{
				UIScript.instance.finish.SetActive(true);
			}
		}
		else 
			Debug.Log ("Error coins");
	}

	public void EndLevel()
	{

		if (level == numberOfLevels)
		{
			GameWon();
		}
		else
		{
			int newlevel = level+1;
			string levelname = "Level" + newlevel;
			Debug.Log("Loading level: " + levelname);
			Application.LoadLevel(levelname);
		}
	}

	void HideLevelScreen()
	{
		UIScript.instance.levelScreen.SetActive(false);
		doingSetUp = false;
	}

	void GameWon()
	{
		UIScript.instance.levelText.text = "Game Won";
		UIScript.instance.levelScreen.SetActive(true);
		StartCoroutine(Wait(2));
		Application.LoadLevel("MainMenu");
	}

	void UpdateText()
	{
		UIScript.instance.coinText.text = "Coins picked up: " + pickedupCoins;
	}

	public void Restart()
	{
		level--;
		UIScript.instance.EndLevel();
		Application.LoadLevel(Application.loadedLevel);
	}

	IEnumerator Wait(float sec)
	{
		Debug.Log("Wait start");
		yield return new WaitForSeconds(sec);
		Debug.Log("Wait stopped");
	}
}
