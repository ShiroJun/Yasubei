using UnityEngine;
using System.Collections;

public class MonoEX : MonoBehaviour {

    public GameObject instantiateGameObject(string path)
    {
        GameObject go = Instantiate(Resources.Load(path)) as GameObject;
        if (go == null)
        {
            Debug.Log("obj = null");
        }
        return go;
    }
    //public IEnumerator DelayMethod(float waitTime)
    //{
    //    yield return new WaitForSeconds(waitTime);
    //}
    public void Destroy()
    {
        Destroy(gameObject);
    }


}
