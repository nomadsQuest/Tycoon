using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seedItem : MonoBehaviour {

	public playerInventory inventory;
	public Transform player;
	public Text purchaseText;
	public string itemText;
	public string button;
	public int seedIdentity;
	// Use this for initialization
	void Start () 
	{
		inventory = GameObject.Find ("player").GetComponent<playerInventory> ();
		player = GameObject.Find ("player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance (player.position, this.transform.position);

		if (dist < 5f)
		{
			purchaseText.text = (itemText);
			if (Input.GetKeyDown (button))
			{
				print ("seedButtonPressed");
				inventory.sort (seedIdentity);
			}
		}else
		{
			purchaseText.text = ("");
		}
			
	}
}
