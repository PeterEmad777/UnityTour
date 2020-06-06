+using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	public GameObject cam1;
	public GameObject cam2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.X))
		{
			cam1.SetActive(true);
			cam2.SetActive(false);
		}
		if (Input.GetKey(KeyCode.Z))
		{
			cam1.SetActive(false);
			cam2.SetActive(true);
		}
	}
}
