using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {

	public int waitTime = 3;
	public GameObject[] FoodItems;
	public Vector3 offset;

	private int foodItem;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (waitForFood ());
	}
	
	// Update is called once per frame
	IEnumerator waitForFood () 
	{
		yield return new WaitForSeconds (waitTime);
	//	Instantiate (FoodItems [Random.Range (0, FoodItems.Length)], transform.position + offset, transform.rotation);

	}

	public void ChosenFoodItem (int _foodItem)
	{
		foodItem = _foodItem;
		Instantiate (FoodItems[_foodItem]  , transform.position + offset, transform.rotation);
	}

	//[Random.Range (0, FoodItems.Length)]
}
