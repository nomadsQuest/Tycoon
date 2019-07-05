using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInventory : MonoBehaviour {

	public int money = 10;
	public int blueBerrySeeds;
	public int carrotSeeds;
	public int weedSeeds;

	public Text blueAmount;
	public Text carrotAmount;
	public Text weedAmount;

	public Text moneyText;


	// Use this for initialization
	void Start () 
	{
		moneyText.text = ("$0");
	}
	
	// Update is called once per frame
	 void Update () 
	{
		
	}

	public void subtractMoney (int _money)
	{
		money -= _money;
		moneyText.text = ("$") + money.ToString ();
	}

	public void addBerry ()
	{
		blueBerrySeeds ++;
		blueAmount.text = ("") + blueBerrySeeds.ToString ();
		subtractMoney (3);

	}

	public void subtractBerry ()
	{
		blueBerrySeeds --;
		blueAmount.text = ("") + blueBerrySeeds.ToString ();
	}

	public void addCarrot ()
	{
		carrotSeeds++;
		carrotAmount.text = ("") + carrotSeeds.ToString ();
		subtractMoney (2);
	}

	public void subtractCarrot ()
	{
		carrotSeeds--;
		carrotAmount.text = ("") + carrotSeeds.ToString ();
	}

	public void addWeed ()
	{
		weedSeeds++;
		weedAmount.text = ("") + weedSeeds.ToString ();
		subtractMoney (1);
	}

	public void subtractWeed ()
	{
		weedSeeds--;
		weedAmount.text = ("") + weedSeeds.ToString ();
	}

	public void sort (int _seed)
	{
		if (_seed == 1)
			addBerry ();

		if (_seed == 2)
			addCarrot ();

		if (_seed == 3)
			addWeed ();
	}
}
