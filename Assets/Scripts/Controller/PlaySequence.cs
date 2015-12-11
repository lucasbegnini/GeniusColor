using UnityEngine;
using System.Collections;

public class PlaySequence : MonoBehaviour {

    private GameObject[] _Colors;

    private int sequenceNumber;

    public float TimeToWaitToPlay;

    public bool CanPlay;

	[SerializeField]
	private int[] Sequence;

	[SerializeField]
	private GameObject HoldAdv;
	

	void Start ()
	{
		Sequence [0] = 0;
		Sequence [1] = 1;
		Sequence [2] = 2;
		sequenceNumber = 3;
	}

	void OnEnable () {
		GetComponent<CheckSequence> ().enabled = false;
		StartCoroutine(Hold());
        //Pega as Cores instanciadas no outro Script
		_Colors = GameObject.FindGameObjectsWithTag ("Player");
		SetSequence ();
        StartCoroutine(PlayGame());
	}

    IEnumerator PlayGame()
    {
		CanPlay = false;
		yield return new WaitForSeconds (1.0f);
        //Toca as cores de uma sequencia randomica/
		for (int i = 0; i < sequenceNumber; i++) {
			_Colors[Sequence[i]].GetComponent<ColorControl>().PlayColor();
			yield return new WaitForSeconds (TimeToWaitToPlay);
		}
        CanPlay = true;
		GetComponent<CheckSequence> ().enabled = true;
	
    }

	void SetSequence()
	{
		int id = Random.Range (0, _Colors.Length);
		Sequence.SetValue (id, sequenceNumber);
		sequenceNumber++;
	}

	public int [] GetSequence()
	{ return Sequence;}

	public int GetsequenceNumber()
	{ return sequenceNumber;}

	IEnumerator Hold()
	{
		HoldAdv.SetActive (true);
		yield return new WaitForSeconds (2.0f);
		HoldAdv.SetActive (false);
	}
	
}
