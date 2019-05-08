using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigatepoints : MonoBehaviour {

	public int gizmoRadius;

	


	void OnDrawGizmos () 
	{
		Gizmos.color = Color.green;
		Gizmos.DrawCube (transform.position,Vector3.one);
		//Gizmos.DrawWireSphere (transform.position,Vector3.one);
	}
}
