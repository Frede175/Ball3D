using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public void LoadLevelOnClick(int level)
	{
		Application.LoadLevel(level);
	}
}
