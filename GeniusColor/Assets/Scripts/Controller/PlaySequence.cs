using UnityEngine;
using System.Collections;

public class PlaySequence : MonoBehaviour {

    private GameObject[] _Colors;
    [SerializeField]
    private int sequenceNumber;

    public float TimeToWaitToPlay;

	[SerializeField]
	private int SizeOfGame;

    public bool CanPlay;

	[SerializeField]
	private int[] Sequence;
	public int step;

	void OnEnable () {
        //Pega as Cores instanciadas no outro Script
        _Colors = GetComponent<InstantiateColors>().getColors();
        StartCoroutine(PlayGame());
	}

    IEnumerator PlayGame()
    {
		CanPlay = false;
		//Zera os passos
		step = 0;
        //Toca as cores de uma sequencia randomica/
        for (int i = 0; i < sequenceNumber; i++)
        {
            _Colors[Sequence[i]].GetComponent<ColorControl>().PlayColor();
            yield return new WaitForSeconds(TimeToWaitToPlay);
        }

        sequenceNumber++;
        CanPlay = true;
		Sequence[sequenceNumber] = Random.Range(0, SizeOfGame);
    }

	public void checkSteps(int entrada)
	{
		if (entrada == Sequence [step]) {
			//Acertou
		} else {
			//Errou
		}

		if (step == (sequenceNumber - 1)) {
			//Ganhou a rodada
		}

	}


	
	
}
