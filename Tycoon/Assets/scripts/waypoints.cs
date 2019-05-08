using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour {

	public Transform [] points;
	//public static List<Transform> points = new List<int> ();
	public int childNumber;


	// Use this for initialization
	void Awake () 
	{
		

		points = new Transform [transform.childCount];

		for (int i = 0; i < points.Length; i++)
		{
			points [i] = transform.GetChild (i);

			}
		}


		

	

}
