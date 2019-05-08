using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {

	public BuildManager buildmanager;
	public build buildScript;
	public int objectPrice = 0;

	void Start()
	{
		buildmanager = BuildManager.instance;
		buildScript = GameObject.Find ("Node").GetComponent<build> ();

	}

	// Use this for initialization
	public void PurchaseFirstItem () 
	{
		Debug.Log ("item 1 selected");
		buildmanager.SetItemToBuild (buildmanager.item1Prefab);
		UpdateItemPrice (20);
	}
	
	// Update is called once per frame
	public void PurchaseSecondItem () 
	{
		Debug.Log ("item 2 selected");
		buildmanager.SetItemToBuild (buildmanager.item2Prefab);
		UpdateItemPrice (5);
	}
		

	public void PurchaseThirdItem () 
	{
		Debug.Log ("item 3 selected");
		buildmanager.SetItemToBuild (buildmanager.item3Prefab);
		UpdateItemPrice (200);
	}


	public void PurchaseFourthItem () 
	{
		Debug.Log ("item 4 selected");
		buildmanager.SetItemToBuild (buildmanager.item4Prefab);
		UpdateItemPrice (8);
	}

	public void PurchaseFifthItem () 
	{
		Debug.Log ("item 5 selected");
		buildmanager.SetItemToBuild (buildmanager.item5Prefab);
		UpdateItemPrice (10);
	}

	public void PurchaseSixthItem () 
	{
		Debug.Log ("item 6 selected");
		buildmanager.SetItemToBuild (buildmanager.item6Prefab);
		UpdateItemPrice (45);
	}

	public void PurchaseSeventhItem () 
	{
		Debug.Log ("item 7 selected");
		buildmanager.SetItemToBuild (buildmanager.item7Prefab);
		UpdateItemPrice (150);
	}

	public void UpdateItemPrice (int _price)
	{
		objectPrice = _price;

	}

}
