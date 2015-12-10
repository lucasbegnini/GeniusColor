using UnityEngine;
using System.Collections;

public class ColorControl : MonoBehaviour {

    PlaySequence GameController;
	[SerializeField]
	private Sprite playOn, playOff;

	private float timeToPlay;
	// Use this for initialization
	void Start () {
        GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlaySequence>();
		timeToPlay = GameController.TimeToWaitToPlay;
	}
	public void PlayColor()
	{
		StartCoroutine (PlayColorChange ());
	}

    private IEnumerator PlayColorChange()
    { 
		GetComponent<SpriteRenderer> ().sprite = playOn;
		yield return new WaitForSeconds (timeToPlay);
		GetComponent<SpriteRenderer> ().sprite = playOff;

	}

    void MouseDown()
    {
        if (GameController.CanPlay)
        {
			PlayColor();
        }
    }
}
