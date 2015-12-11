using UnityEngine;
using System.Collections;

public class MenuBntsControl : MonoBehaviour {

	public void restart()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void home()
	{
		Application.LoadLevel ("inicio");
	}

	public void about()
	{
		Application.LoadLevel ("credits");
	}

	public void quit()
	{
		Application.Quit();
	}
}
