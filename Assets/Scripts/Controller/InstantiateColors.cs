using UnityEngine;
using System.Collections;

public class InstantiateColors : MonoBehaviour {

    [SerializeField]
    private GameObject[] Colors;

	[SerializeField]
    private GameObject[] _Colors;

  

	void Start()
	{
		InstantiateGameColors ();

	}

    void InstantiateGameColors()
    {
        //Instancia todos as Cores
        for (int i = 0; i < _Colors.Length; i++)
        {
	//		GameObject.Instantiate(Colors[i]);
            _Colors[i] = GameObject.Instantiate(Colors[i]) as GameObject;
        }
    }

}
