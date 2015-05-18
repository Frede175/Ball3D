using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {

	public static UIScript instance = null;

	public Text coinText = null;
	public Text levelText = null;
	public GameObject levelScreen = null;
	public GameObject finish = null;

	// Use this for initialization
	void Awake()
	{
		instance = this;
		coinText = coinText.GetComponent<Text>();
		levelText = levelText.GetComponent<Text>();

	}
	
	public void EndLevel()
	{
		coinText = null;
		levelText = null;
		Destroy(gameObject);
	}
}
