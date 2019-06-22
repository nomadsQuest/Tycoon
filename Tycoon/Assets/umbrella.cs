using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class umbrella : MonoBehaviour {

	public Animator anim;
	public daynightcycle cycle;
	public int rand;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent <Animator> ();
		cycle = GameObject.Find ("sun").GetComponent<daynightcycle> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cycle.hotSun != false)
		{
	
			StartCoroutine (openUmbrellaRandom ());

		}else
		{
			StartCoroutine (closeUmbrellaRandom ());
		}
	}

	IEnumerator openUmbrellaRandom()
	{
		rand = Random.Range (1, 5);
		print ("isOpening");
		yield return new WaitForSeconds (rand);
		anim.SetBool ("isOpen", true);

	}

	IEnumerator closeUmbrellaRandom()
	{
		rand = Random.Range (1, 5);
		print ("isClosing");
		yield return new WaitForSeconds (rand);
		anim.SetBool ("isOpen", false);

	}

}
