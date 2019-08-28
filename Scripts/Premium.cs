using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Premium : MonoBehaviour {
    public GameObject reticle;
    public GameObject text;
    private int timer = 0;
    private bool PremiumMsg = false;
    // Use this for initialization
    void Start()
    {
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
                text.SetActive(true);
                reticle.SetActive(false);
                PremiumMsg = true;
            }
        }
        if (PremiumMsg == true)
        {
            timer += 1;
            if (timer == 200)
            {
                text.SetActive(false);
                reticle.SetActive(true);
                PremiumMsg = false;
                timer = 0;
            }
        }
    }
}
