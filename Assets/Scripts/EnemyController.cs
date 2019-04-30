﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float maxCloseness;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = maxCloseness;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var rayPosition = player.transform.position - transform.position;
        if (Physics.Raycast (transform.position, rayPosition, out hit))
        {
            if (hit.transform == player.transform)
            {
                agent.SetDestination(player.transform.position);
            }
            //Debug.DrawRay(transform.position, rayPosition, Color.yellow);
        }
    }
}
