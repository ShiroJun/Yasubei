﻿using UnityEngine;

public class EnemyB : NinjaCounts
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private Animator anim;
    CapsuleCollider cap;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        agent.autoBraking = false;
        cap = GetComponent<CapsuleCollider>();
        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bakufu"))
        {
            ninjaCount -= 1;
            anim.SetTrigger("Death");
            agent.speed = 0;
            cap.enabled = false;
            Invoke("Destroy", 2);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("attack");
        }
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}
