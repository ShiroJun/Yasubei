using UnityEngine;
using System.Collections;

public class Akudaikan : MonoBehaviour {

   // public Transform target;
    NavMeshAgent agent;
    private Animator anim;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //anim.SetBool("Escape", true);
        //agent.SetDestination(target.position);


    }
    void OnTriggerStay(Collider other)
    {
        anim.SetBool("Escape",true);
        Vector3 dir = this.transform.position - other.transform.position;
        Vector3 pos = this.transform.position + dir * 1f;
        agent.destination = pos;
    }
}
