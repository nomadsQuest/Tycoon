using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Market : MonoBehaviour {

	public List<int> bread = new List<int> ();
	public List<int> fruit = new List<int> ();
	public List<int> herb = new List<int> ();
	public int money = 100;
	public Text moneyText;
	 
	// Use this for initialization
	void Start () 
	{
		moneyText.text = "" + money.ToString();
	}
	
	// Update is called once per frame
	public void AddIngredient1 () 
	{
		if (money >= 4)
		{
		money -= 4;
		moneyText.text = "" + money.ToString();
		bread.Add (1);
		}
		else
		{
			print ("not enough money!");
		}
	}

	public void AddIngredient2 () 
	{
		if (money >= 20)
		{
			money -= 20;
			moneyText.text = "" + money.ToString();
			fruit.Add (1);
		}
		else
		{
			print ("not enough money!");
		}
	}

	public void AddIngredient3 () 
	{
		if (money >= 50)
		{
			money -= 50;
			moneyText.text = "" + money.ToString();
			herb.Add (1);
		}
		else
		{
			print ("not enough money!");
		}
	}

	public void ExitShop ()
	{
		this.gameObject.SetActive (!gameObject.activeSelf);
	}
}
