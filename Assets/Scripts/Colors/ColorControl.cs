using UnityEngine;
using System.Collections;

public class ColorControl : MonoBehaviour {

    PlaySequence GameController;
	[SerializeField]
	private GameObject playOn;

	private float timeToPlay;

	[SerializeField]
	private int ID;

	private AudioSource audio;
	void Start () {
		playOn.SetActive (false);
		audio = GetComponent<AudioSource> ();
        GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlaySequence>();

	}
	public void PlayColor()
	{
		StartCoroutine (PlayColorChange ());
	}

    private IEnumerator PlayColorChange()
    { 
	
		timeToPlay = GameController.TimeToWaitToPlay;
		playOn.SetActive (true);
		audio.Play ();
		yield return new WaitForSeconds (timeToPlay-0.5f);
		playOn.SetActive (false);

	}

    void OnMouseDown()
    {
        if (GameController.CanPlay)
        {
			PlayColor();
			GameController.GetComponent<CheckSequence>().verificar(ID);
        }
    }

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine(PlayColorChange());
		}

	}
}
