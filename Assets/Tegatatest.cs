using UnityEngine;
using System.Collections;

public class Tegatatest : MonoBehaviour
{

    private GameObject tegata;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        tegata = GameObject.Find("Tegata");
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Tegata1")
        {
            anim.SetBool("Victory", true);
            Invoke("ToStage3", 3f);
        }
        if (other.gameObject.name == "Tegata2")
        {
            anim.SetBool("Victory", true);
            Invoke("ToStageBoss", 3f);
        }

    }


    public void ToStage3()
    {
        Application.LoadLevel("Stage3");
    }
    public void ToStageBoss()
    {
        Application.LoadLevel("BossStage");
    }
}
