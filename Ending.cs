using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    public GameObject guiObject;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4);
    }
}
