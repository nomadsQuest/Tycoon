using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateShop : MonoBehaviour {
	public Canvas shop;
	// Use this for initialization
	void Start () 
	{
		shop = GameObject.Find ("shop").GetComponent<Canvas> ();
	}

	public void Open ()
	{
		shop.gameObject.SetActive (!shop.gameObject.activeSelf);
			
	}

	// Update is called once per frame

}
