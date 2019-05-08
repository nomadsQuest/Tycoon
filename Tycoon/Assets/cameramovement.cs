using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour {


	public RotationAxis axes = RotationAxis.MouseX;

	public float minumumVert = -45f;
	public float maximumVert = 45f;

	public float sensHor = 10f;
	public float sensVert = 10f;

	public float rotationX = 0f;


	public enum RotationAxis{
		MouseX = 1,
		MouseY = 2
	}





	// Use this for initialization
	void Start () 
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		if (axes == RotationAxis.MouseX){
			transform.Rotate (0, Input.GetAxis ("Mouse X") * sensHor, 0);
	}else if(axes == RotationAxis.MouseY){
	rotationX += Input.GetAxis("Mouse Y") * sensVert;
	rotationX = Mathf.Clamp(rotationX, minumumVert, maximumVert);
	}

float rotationY = transform.localEulerAngles.y;
	transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);


	}
}
