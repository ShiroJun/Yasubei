using UnityEngine;
using System.Collections;

public class Akudaikan : MonoBehaviour {

   // public Transform target;
    NavMeshAgent agent;
    private Animator anim;
    public int hp = 3;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //anim.SetBool("Escape", true);
        //agent.SetDestination(target.position);

        if(hp == 0)
        {
            Destroy(gameObject);
        }


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Range"))
        {
         anim.SetBool("Escape",true);
         Vector3 dir = this.transform.position - other.transform.position;
         Vector3 pos = this.transform.position + dir * 2.5f;
         agent.destination = pos;
        }
        if (other.gameObject.CompareTag("Bakufu"))
        {
            hp = hp-1;
        }

    }
}
