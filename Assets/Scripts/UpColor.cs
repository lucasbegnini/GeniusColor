using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpColor : MonoBehaviour {

	private int Level;
	private Color red,blue,yellow, magenta; 
	void Start () {
		Level = 1;
		red = new Color (254.0f,6.0f,6.0f,1.0f);
		blue = new Color (29.0f,83.0f,232.0f,1.0f);
		yellow = new Color (254.0f,192.0f,6.0f,1.0f);
		magenta = new Color (232.0f,29.0f,98.0f,1.0f);
	}

	public void UpLevel()
	{
		Level++;
		GetComponent<Text> ().text = Level.ToString();
		//GetComponent<Text> ().color = setCor ();
	}

	Color setCor()
	{
		int rand = Random.Range (0, 3);
		if (rand == 0)
			return red;
		if (rand == 1)
			return blue;
		if (rand == 2)
			return yellow;
		if (rand == 3)
			return magenta;
		else
			return Color.black;

	}
	public int getLevel()
	{
		return Level;
	}
}
