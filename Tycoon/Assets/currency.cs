using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currency : MonoBehaviour {

	public Text moneyText;
	public int money = 100;

	// Use this for initialization
	void Start () 
	{
		moneyText = GameObject.Find ("moneytxt").GetComponent<Text> ();
		moneyText.text = "" + money.ToString ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void subtractMoney (int _money)
	{
		money -= _money;
		moneyText.text = "" + money.ToString ();
	}

	public void addMoney (int _money)
	{
		money += _money;
		moneyText.text = "" + money.ToString ();
	}
}
