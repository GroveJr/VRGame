using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Die : MonoBehaviour {
    public GameObject dead;
    public GameObject reticle;
    private int back = 0;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider col)
    {
        dead.SetActive(true);
        reticle.SetActive(false);
        back += 1;
        if (back == 5)
        {
            SceneManager.LoadScene(0);
        }
    }
}
