using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

	public static Text coinText;
	public static Text levelText;
	public static GameObject levelScreen;
	public static GameObject finish;

	void Awake()
	{
		//Set up:
		coinText = coinText.GetComponent<Text>();
		levelText = levelText.GetComponent<Text>();

	}

	// Update is called once per frame
	void Update () {
		coinText.text = "Coins Pickedup: " + GameManager.instance.pickedupCoins;
		levelText.text = "Level " + GameManager.instance.level;
	}
}
