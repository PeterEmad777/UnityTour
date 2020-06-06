using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicComponents : MonoBehaviour {

	// Use this for initialization
	public AudioSource a1;
	public bool run = true;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.M))
		{
			run = false;
			a1.Stop();
		}
		else if (Input.GetKey(KeyCode.U))
		{
			run = true;
			a1.Play();
		}

	}
}
