using UnityEngine;
using System.Collections;

public class SplashControl : MonoBehaviour {

	public string SceneToGo;
 	IEnumerator Start () {
		yield return new WaitForSeconds (1.5f);
		Application.LoadLevel (SceneToGo);
	}
	

}
