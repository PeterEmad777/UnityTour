using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextAppear : MonoBehaviour {

	// Use this for initialization]

	//public Text data;
	//public string txt;
	//public ScrollRect scroll;
	public GameObject guiObject;



    // Update is called once per fram
    void OnTriggerEnter(Collider other)
	{
		if(ScoringSystem.theScore == 50)
		{
			SceneManager.LoadScene(3);
		}
		else
		{
            guiObject.GetComponent<Text>().text = "You need 50 coins";
		}

	}
}
