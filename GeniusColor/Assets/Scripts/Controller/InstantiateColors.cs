using UnityEngine;
using System.Collections;

public class InstantiateColors : MonoBehaviour {

    [SerializeField]
    private GameObject[] Colors;
    private GameObject[] _Colors;

    [SerializeField]
    private int NumberOfColors;


    void InstantiateGameColors()
    {
        //Instancia todos as Cores
        for (int i = 0; i < NumberOfColors; i++)
        {
            _Colors[i] = GameObject.Instantiate(Colors[i]) as GameObject;
        }
    }

    public GameObject[] getColors()
    { return Colors; }
}
