using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FireCreator : MonoBehaviour {

    public GameObject hanabi;

    void Start()
    {
        StartCoroutine("Bighanabi");
        Invoke("Ending", 5);

    }
    void Update()
    {

    }
    // コルーチン
    private IEnumerator Bighanabi()
    {
      while (true)
       {
          Instantiate(hanabi, transform.position, transform.rotation);
            yield return new WaitForSeconds(2.0f);      
       } 
                  
    }
    void Ending()
    {
        SceneManager.LoadScene("MovieTest");
    }
   
}
