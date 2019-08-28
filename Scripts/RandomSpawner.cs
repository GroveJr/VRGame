using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {
    public GameObject[] enemies;
    public int maxtimer = 10;
    public int mintimer = 3;
    private float timer;
    private float timetospawn;
	// Use this for initialization
	void Start () {
        timetospawn = Random.Range(mintimer, maxtimer);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > timetospawn)
        {
            timer = 0;
            timetospawn = Random.Range(mintimer, maxtimer);
            Debug.Log(timetospawn);
            Spawn(Random.Range(0, enemies.Length));
        }
	}
    void Spawn(int index)
    {
        Instantiate(enemies[index], transform.position, transform.rotation);
    }
}
