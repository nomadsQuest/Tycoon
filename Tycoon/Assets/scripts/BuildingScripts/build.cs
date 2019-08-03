using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class build : MonoBehaviour {

	public Color hoverColor;

	private Renderer rend;

	private GameObject prefabItem;

	public Vector3 positionOffset;

	BuildManager buildmanager;

	public int buildMoney;

	public currency money;

	public shop itemShop;


	//private Color startColor;


	// Use this for initialization
	void Start () 
	{

		money = GameObject.Find ("PlayerCurrency").GetComponent<currency> ();

		itemShop = GameObject.Find ("shop").GetComponent<shop> ();


		//startColor = rend.sharedmaterial.color;
		rend = GetComponent<Renderer>();

		buildmanager = BuildManager.instance;
	}

	void OnMouseDown()
	{

	
		if (EventSystem.current.IsPointerOverGameObject ())
		return;

		//	if (buildmanager.GetTurretToBuild () == null)
		//	return;

		if(prefabItem != null)
		{
			print ("Cant Build There");
			return;
		}

		GameObject itemToBuild = buildmanager.GetItemtoBuild();
		prefabItem = (GameObject)Instantiate(itemToBuild, transform.position + positionOffset, itemToBuild.transform.rotation);

		money.subtractMoney (buildMoney);



	}
	// Update is called once per frame
	void OnMouseEnter () 
	{
		//if (EventSystem.current.IsPointerOverGameObject ())
		//	return;
		
		//if (buildmanager.GetTurretToBuild () == null)
		//	return;
		
		rend.material.color = hoverColor;
	}

	void OnMouseExit()
	{
		//print ("exiting");
		rend.material.color = Color.white;

	}

	void Update ()
	{
		buildMoney = itemShop.objectPrice;
	}




}
