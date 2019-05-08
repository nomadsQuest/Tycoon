using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class marketSeller: MonoBehaviour {


	public Camera cam;

	public Canvas shop;


	// Use this for initialization
	void Start () 
	{
		 
		shop = GameObject.Find("Market").GetComponent<Canvas> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))

		{
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.name == "seller")
				{
					if (EventSystem.current.IsPointerOverGameObject ())
						return;
					
					shop.gameObject.SetActive (!shop.gameObject.activeSelf);
				}
			}
		}
}
}