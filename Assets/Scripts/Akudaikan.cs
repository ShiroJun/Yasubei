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
    private GameObject gamec;
    private AudioSource audio;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        cap = GetComponent<CapsuleCollider>();
        bighanabi = GameObject.Find("BigHanabi");
        bighanabi.SetActive(false);
        gamec = GameObject.Find("GameController");
        audio = gamec.GetComponent<AudioSource>();

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
         Vector3 pos = this.transform.position + dir * 2.5f;
         agent.destination = pos;
        }
        if (other.gameObject.CompareTag("Bakufu"))
        {
            hp = hp-1;
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
}
