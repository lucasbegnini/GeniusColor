using UnityEngine;
using System.Collections;

public class CheckSequence : MonoBehaviour {

	private int[] sequence ;
	private int contador;
	private bool acertou;
	private int sequenceNumber;

	[SerializeField]
	private GameObject GoAdv;

	[SerializeField]
	private GameObject GameOverPanel;

	void OnEnable () {
		GetComponent<PlaySequence> ().enabled = false;
		StartCoroutine(Go());
		sequence = GetComponent<PlaySequence> ().GetSequence ();
		sequenceNumber = GetComponent<PlaySequence> ().GetsequenceNumber ();
		contador = 0;
	}
	
	public void verificar(int valor)
	{
		
		
		if (sequence [contador] == valor) {
			//Acertou
			contador++;
			//acertou = true;
		} else {
			//Errou
			GetComponent<PlaySequence>().CanPlay = false;
			GameOverPanel.SetActive(true);
		}
		
		if (sequenceNumber == contador) {
			StartCoroutine(Restart());
		}
	}

	IEnumerator Restart()
	{
		GameObject.FindGameObjectWithTag ("LevelTag").GetComponent<UpColor> ().UpLevel ();
		yield return new WaitForSeconds (2.0f);
		GetComponent<PlaySequence> ().enabled = true;
	}

	IEnumerator Go()
	{
		GoAdv.SetActive (true);
		yield return new WaitForSeconds (2.0f);
		GoAdv.SetActive (false);
	}
}
