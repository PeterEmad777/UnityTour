using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityScript.Steps;

public class CameraScript : MonoBehaviour {


	public Transform focus;

	public Transform target;

	public Vector3 offset;

	public bool useOffsetValues;

	public float rotateSpeed;

	public Transform pivot;




	//public float rotateSpeed;
	// Use this for initialization

	void Start () {
		if (!useOffsetValues)
		{
			offset = focus.position - transform.position;
		}
		pivot.transform.position = target.transform.position;
		pivot.transform.parent = target.transform;

		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		//get X Position
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		target.Rotate(0, horizontal, 0);

		//Move Camera x, Y
		float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
		pivot.Rotate(-vertical, 0, 0);

		//get Y of mouse and rotate

		float angleY = target.eulerAngles.y;
		float angleX = pivot.eulerAngles.x;
		Quaternion rotation = Quaternion.Euler(angleX, angleY, 0);
		transform.position = focus.position + (rotation  * offset);


		//transform.position = focus.position - offset;
		
		transform.LookAt(focus);
	}
}
