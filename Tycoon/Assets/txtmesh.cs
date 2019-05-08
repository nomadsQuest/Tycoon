using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class txtmesh : MonoBehaviour {

	public Text UItext;
	public TextMeshPro Txtpro;

	// Use this for initialization
	void Start () 
	{
		//TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
		Txtpro.text = "Example of text to be displayed.";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
