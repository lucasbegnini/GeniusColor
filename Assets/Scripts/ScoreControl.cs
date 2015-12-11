using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour {

	void OnEnable()
	{
		int _score = GameObject.FindGameObjectWithTag ("LevelTag").GetComponent<UpColor> ().getLevel();
		SaveBestScore (_score);
		GetComponent<Text> ().text = _score.ToString();

		GameObject.FindGameObjectWithTag("BestScore").GetComponent<Text> ().text = PlayerPrefs.GetInt ("BestScore").ToString ();
	}

	void SaveBestScore(int entrada)
	{
		if (PlayerPrefs.GetInt ("BestScore") < entrada) {
			PlayerPrefs.SetInt("BestScore", entrada);
		}

	}
}
