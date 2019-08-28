using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRClickDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	public void MeDestroy () {
        Destroy(gameObject);
	}

    bool entered;
    public void SetGazedAt(bool gazestat)
    {
        entered = gazestat;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (entered)
            {
                Destroy(gameObject);
            }
        }
    }
}
