using UnityEngine;
using System.Collections;

public class EnemyA : MonoBehaviour {

    private Transform target;
    private GameObject player;
    NavMeshAgent agent;
    private Animator anim;

    void Start()
    {
        player = GameObject.Find("Player");
        target = player.GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
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
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("attack");
        }
    }
}
