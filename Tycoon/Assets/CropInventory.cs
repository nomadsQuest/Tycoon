using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CropInventory : MonoBehaviour {

	public Text berry;
	public Text carrot;
	public Text weed;

	public int berryAmount;
	public int carrotAmount;
	public int weedAmount;

	public int locateNumber;

	// Use this for initialization
	void Start () 
	{
		berry.text = ("") + berryAmount.ToString ();
		carrot.text = ("") + carrotAmount.ToString ();
		weed.text = ("") + weedAmount.ToString ();
	}
	
	// Update is called once per frame
	public void addBerry (int _amount) 
	{
		berryAmount += _amount;
		berry.text = ("") + berryAmount.ToString ();
	}

	public void addCarrot (int _amount)
	{
		carrotAmount += _amount;
		carrot.text = ("") + carrotAmount.ToString ();
	}

	public void addWeed (int _amount)
	{
		weedAmount += _amount;
		weed.text = ("") + weedAmount.ToString ();
	}

	public void locate (int _locateNumber)
	{
		if (_locateNumber == 1)
			addBerry (1);

		if (_locateNumber == 2)
			addCarrot (1);

		if (_locateNumber == 3)
			addWeed (1);

			
	}

}
