using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTcarSpawn : MonoBehaviour {

	public GameObject dtCar;
	public int waitTime;
	public bool isSpawn = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		waitTime = Random.Range (4, 8);

		if (isSpawn != true)
		{
			StartCoroutine (DTcar());
			isSpawn = true;
		}
	}

	IEnumerator DTcar()
	{
		yield return new WaitForSeconds (waitTime);
		Instantiate (dtCar, transform.position, transform.rotation);

	}
}
