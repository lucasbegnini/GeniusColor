using UnityEngine;
using System.Collections;

public class StarterControl : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (1.5f);
		GetComponent<PlaySequence> ().enabled = true;
	}

}
