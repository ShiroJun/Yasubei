using UnityEngine;
using System.Collections;

public class Akudaikan : PlayerLife
{

   // public Transform target;
    NavMeshAgent agent;
    CapsuleCollider cap;
    private Animator anim;
    public static int hp = 3;
    private GameObject bighanabi;
    private GameObject bossbgm;
    private AudioSource audio;
    private Rigidbody rigidbody;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        cap = GetComponent<CapsuleCollider>();
        bighanabi = GameObject.Find("BigHanabi");
        bighanabi.SetActive(false);
        bossbgm = GameObject.Find("BossBGM");
        audio = bossbgm.GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //anim.SetBool("Escape", true);
        //agent.SetDestination(target.position);

        if (hp <= 0)
        {
            audio.Stop();
            anim.SetTrigger("Death");
            agent.enabled = false;
            cap.enabled = false;
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            //Invoke("Death", 3);
            Invoke("FireCreator", 4);
        }


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Range"))
        {
         anim.SetBool("Escape",true);
         Vector3 dir = this.transform.position - other.transform.position;
         Vector3 pos = this.transform.position + dir * 1.75f;
         agent.destination = pos;
        }
        if (other.gameObject.CompareTag("Bakufu"))
        {
            hp = hp-1;
            Damagespace();
        }

    }
    void Death()
    {
        Destroy(gameObject);
    }
    void FireCreator()
    {
        bighanabi.gameObject.SetActive(true);
    }
    void Colliderset()
    {
        cap.enabled = true;
    }
    void Damagespace()
    {
        cap.enabled = false;
        Invoke("Colliderset", 2);
    }
}
