using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResources : MonoBehaviour {

	public int playerMoney = 0;

	public Text moneyText;





	// Use this for initialization
	void Start () 
	{
		moneyText.text = "Money:" + playerMoney.ToString ();


	}
	
	// Update is called once per frame
	public void AddMoney (int money) 
	{
		playerMoney += money; 
		moneyText.text = "" + playerMoney.ToString ();
	}

	void Update ()
	{


	}
}
