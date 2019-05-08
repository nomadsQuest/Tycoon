using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testtextmeshpro : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		TextMeshProUGUI textmeshpro = GetComponent<TextMeshProUGUI> ();
		textmeshpro.text = "Example";
	}
	
	// Update is called once per frame
	void Update () 

	{
		
	}
}
