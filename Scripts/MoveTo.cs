using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	Transform goal;
    UnityEngine.AI.NavMeshAgent agent;

    void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject siPlayer = GameObject.Find("Player");
        goal = siPlayer.transform;
    }

    void Update()
    {
        agent.destination = goal.position;
    }
}