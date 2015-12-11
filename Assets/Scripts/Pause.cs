using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	[SerializeField]
	private GameObject pausePanel;
	[SerializeField]
	private Button pauseButton;
	// Use this for initialization
	void Start () {
		pausePanel.SetActive(false);
		Time.timeScale = 1.0f;
	}
	
	public void ResumeGame()
	{
		pausePanel.SetActive(false);
		pauseButton.gameObject.SetActive(true);
		Time.timeScale = 1.0f;

	}

	public void PauseGame()
	{
		pausePanel.SetActive(true);
		pauseButton.gameObject.SetActive(false);
		Time.timeScale = 0.0f;
	}
}
