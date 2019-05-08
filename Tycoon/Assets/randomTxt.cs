using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class randomTxt : MonoBehaviour {

	public Text randomNumberText;

	void Start()
	{
		randomNumberText.text = ("");
	}

	public int randomIntExcept( int min, int max, int except )
	{
		int result = Random.Range( min, max - 1);
		if (result >= except) result += 1;
		return result;
	}
}
