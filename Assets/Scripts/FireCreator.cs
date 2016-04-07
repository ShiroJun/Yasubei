using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FireCreator : MonoBehaviour {

    public GameObject hanabi;
    public GameObject hanabi2;
    public GameObject hanabi3;

    void Start()
    {
        StartCoroutine("Bighanabi");
        Invoke("Ending", 7);

    }
    void Update()
    {

    }
    // コルーチン
    private IEnumerator Bighanabi()
    {
      while (true)
       {
            Hanabipattern();
            Invoke("Hanabipattern2", 1);
            Invoke("Hanabipattern3", 0.7f);
            yield return new WaitForSeconds(2.0f);        
        } 
                  
    }
    void Ending()
    {
        SceneManager.LoadScene("MovieTest");
    }
   void Hanabipattern()
    {
        Instantiate(hanabi, hanabi.transform.position, transform.rotation);
    }
    void Hanabipattern2()
    {
        Instantiate(hanabi2, hanabi2.transform.position, transform.rotation);
    }
    void Hanabipattern3()
    {
        Instantiate(hanabi3, hanabi3.transform.position, transform.rotation);
    }
}
