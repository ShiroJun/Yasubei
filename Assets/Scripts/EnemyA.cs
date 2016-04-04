﻿using UnityEngine;
using System.Collections;

public class EnemyA : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bakufu"))
        {
            Destroy(gameObject);
        }
    }
}
