using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public int numberOfCoinsInLevel;
	public int numberOfLevels;
	public bool doingSetUp = false;

	float levelWait = 2f;
	int numberOfCoins = 0;
	public int pickedupCoins = 0;
	public static int level = 0;


	void Awake()
	{
		doingSetUp = true;
		DontDestroyOnLoad (gameObject);
		instance = this;
		InitGame();

	}

	void OnLevelWasLoaded(int index)
	{
		level++;
		InitGame();
	}

	void InitGame()
	{
		doingSetUp = true;
		UIManager.levelText.text = "Level " + level;
		UIManager.levelScreen.SetActive(true);
		numberOfCoins = numberOfCoinsInLevel;
		UpdateText();
		UIManager.finish.SetActive(false);
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
				UIManager.finish.SetActive(true);
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
			enabled = false;
		}
		else
		{
			int newlevel = level+1;
			string levelname = "Level" + newlevel;
			Debug.Log("Laoding level: " + levelname);
			Application.LoadLevel(levelname);
		}
	}

	void HideLevelScreen()
	{
		UIManager.levelScreen.SetActive(false);
		doingSetUp = false;
	}

	void GameWon()
	{
		UIManager.levelText.text = "Game Won";
		UIManager.levelScreen.SetActive(true);
	}

	void UpdateText()
	{
		UIManager.coinText.text = "Coins picked up: " + pickedupCoins;
	}

	public void Restart()
	{
		level--;
		Application.LoadLevel(Application.loadedLevel);
	}
}
