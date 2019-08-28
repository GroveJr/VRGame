using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGrave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	// Update is called once per frame

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
				SceneManager.LoadScene(1);
			}
		}
	}
}
